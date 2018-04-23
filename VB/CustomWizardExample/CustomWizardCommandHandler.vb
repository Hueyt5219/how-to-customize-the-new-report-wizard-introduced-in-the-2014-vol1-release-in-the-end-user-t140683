Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Xml.Linq
Imports CustomWizardExample.Wizard
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.Data.Entity
Imports DevExpress.DataAccess.EntityFramework.Native
Imports DevExpress.DataAccess.Native
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Native
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Entity.ProjectModel
Imports DevExpress.LookAndFeel
Imports DevExpress.LookAndFeel.DesignService
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.Wizards3.Builder

Namespace CustomWizardExample
    Public Class CustomWizardCommandHandler
        Implements ICommandHandler

        Private mdiController As XRDesignMdiController

        Public Sub New(ByVal mdiController As XRDesignMdiController)
            Me.mdiController = mdiController
        End Sub

#Region "Implementation of ICommandHandler"

        Public Sub HandleCommand(ByVal command As ReportCommand, ByVal args() As Object) Implements ICommandHandler.HandleCommand
            Select Case command
                Case ReportCommand.NewReportWizard
                    OnNewReportWizard()
                Case ReportCommand.AddNewDataSource
                    OnAddNewDataSource()
            End Select
        End Sub

        Public Function CanHandleCommand(ByVal command As ReportCommand, ByRef useNextHandler As Boolean) As Boolean Implements ICommandHandler.CanHandleCommand
            useNextHandler = Not (command = ReportCommand.NewReportWizard OrElse command = ReportCommand.AddNewDataSource)
            Return Not useNextHandler
        End Function

#End Region

        Private Sub OnNewReportWizard()
            mdiController.OpenReport(New XtraReport())

            Dim designerHost As IDesignerHost = TryCast(mdiController.ActiveDesignPanel.GetService(GetType(IDesignerHost)), IDesignerHost)
            Debug.Assert(designerHost IsNot Nothing, "host != null")

            Dim runner As CustomReportWizardRunner = CreateCustomReportWizardRunner(designerHost)
            Dim client As DataSourceWizardClient = CreateDataSourceWizardClient(designerHost)

            If runner.Run(client) <> DialogResult.OK Then
                Return
            End If

            mdiController.Form.BeginInvoke(New MethodInvoker(Sub()
                                                                 Dim undoEngine As UndoEngine = DirectCast(designerHost.GetService((GetType(UndoEngine))), UndoEngine)
                                                                 Dim myMethod As System.Action = Sub()
                                                                                                     Dim builder As New XtraWizardReportBuilderWrapper(designerHost)
                                                                                                     builder.Build(runner.WizardModel, True, CreateDataComponent(runner.WizardModel))
                                                                                                 End Sub
                                                                 undoEngine.ExecuteWithoutUndo(myMethod)
                                                             End Sub))
        End Sub

        Private Sub OnAddNewDataSource()
            Dim designerHost As IDesignerHost = TryCast(mdiController.ActiveDesignPanel.GetService(GetType(IDesignerHost)), IDesignerHost)
            Debug.Assert(designerHost IsNot Nothing, "host != null")

            Dim runner As CustomDataSourceWizardRunner = CreateCustomDataSourceWizardRunner(designerHost)
            Dim client As DataSourceWizardClient = CreateDataSourceWizardClient(designerHost)

            If runner.Run(client) <> DialogResult.OK Then
                Return
            End If

            Dim dataComponent = CreateDataComponent(runner.WizardModel)

            If TypeOf dataComponent Is IComponent Then
                Dim designerTransaction As DesignerTransaction = designerHost.CreateTransaction()
                designerHost.Container.Add(DirectCast(dataComponent, IComponent))
                designerTransaction.Commit()
            End If
            Dim report As XtraReport = DirectCast(designerHost.RootComponent, XtraReport)
            If report.DataSource Is Nothing Then
                TypeDescriptor.GetProperties(report)("DataSource").SetValue(report, dataComponent)
                TypeDescriptor.GetProperties(report)("DataMember").SetValue(report, dataComponent.DataMember)
            End If
        End Sub

        Private Shared Function CreateDataSourceWizardClient(ByVal host As IDesignerHost) As DataSourceWizardClient
            Dim solutionTypesProvider As ISolutionTypesProvider = EntityServiceHelper.GetRuntimeSolutionProvider(System.Reflection.Assembly.GetEntryAssembly())
            Dim connectionStringsProvider As IConnectionStringsProvider = New RuntimeConnectionStringsProvider()
            Dim connectionService As IConnectionStorageService = New ConnectionStorageService()
            Dim parameterService As IParameterService = DirectCast(host.GetService(GetType(IParameterService)), IParameterService)
            Return New DataSourceWizardClient(connectionService, parameterService, solutionTypesProvider, connectionStringsProvider)
        End Function

        Private Shared Function CreateCustomReportWizardRunner(ByVal host As IDesignerHost) As CustomReportWizardRunner
            Dim lookAndFeel As UserLookAndFeel = DirectCast(host.GetService(GetType(ILookAndFeelService)), ILookAndFeelService).LookAndFeel
            Dim uiService As IUIService = DirectCast(host.GetService(GetType(IUIService)), IUIService)
            Dim owner As IWin32Window = If(uiService IsNot Nothing, uiService.GetDialogOwnerWindow(), Nothing)

            Return New Wizard.CustomReportWizardRunner(lookAndFeel, owner)
        End Function

        Private Shared Function CreateCustomDataSourceWizardRunner(ByVal host As IDesignerHost) As CustomDataSourceWizardRunner
            Dim lookAndFeel As UserLookAndFeel = DirectCast(host.GetService(GetType(ILookAndFeelService)), ILookAndFeelService).LookAndFeel
            Dim uiService As IUIService = DirectCast(host.GetService(GetType(IUIService)), IUIService)
            Dim owner As IWin32Window = If(uiService IsNot Nothing, uiService.GetDialogOwnerWindow(), Nothing)

            Return New Wizard.CustomDataSourceWizardRunner(lookAndFeel, owner)
        End Function

        Private Shared Function CreateDataComponent(ByVal model As CustomReportModel) As IDataComponent
            If model.DataSourceType Is CustomDataSourceType.Persons Then
                If model.PersonsDataSourceType = PersonsDataSourceType.Xml Then
                    Dim root = System.Xml.Linq.XDocument.Load("Data.xml").Root
                    Dim persons As New List(Of Person)()
                    For Each item In root.Elements()
                        Dim firstName = item.GetAttributeValue("FirstName")
                        Dim secondName = item.GetAttributeValue("SecondName")

                        Dim person = New Person() With {.FirstName = firstName, .SecondName = secondName}
                        persons.Add(person)
                    Next item
                    Return New ListDataSource(persons)
                Else
                    Dim staticPersons = New List(Of Person)({
                     New Person() With {.FirstName = "John", .SecondName = "Small"},
                     New Person() With {.FirstName = "Paul", .SecondName = "Green"},
                     New Person() With {.FirstName = "George", .SecondName = "White"}
                    })
                    Return New ListDataSource(staticPersons)
                End If
            End If
            Return model.CreateDataComponent()
        End Function
    End Class
End Namespace
