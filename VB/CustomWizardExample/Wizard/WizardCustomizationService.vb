Imports System.ComponentModel.Design
Imports CustomWizardExample.Wizard.Presenters
Imports CustomWizardExample.Wizard.Views
Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.XtraReports.Wizards3
Imports DevExpress.XtraReports.Wizards3.Presenters

Namespace CustomWizardExample.Wizard
    Friend Class WizardCustomizationService
        Implements IWizardCustomizationService

        Private Sub IWizardCustomizationService_CustomizeDataSourceWizard(ByVal tool As IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeDataSourceWizard
            ' Set the start page.
            tool.StartPage = GetType(ChoosePersonsPage2(Of DataSourceModel))

            ' Register the custom page.
            tool.RegisterPage(Of ChoosePersonsPage2(Of XtraReportModel), ChoosePersonsPage2(Of XtraReportModel))()

            ' Register the custom page view.
            tool.RegisterPageView(Of IChoosePersonsPageView, ChoosePersonsPageView2)()
        End Sub
        Private Sub IWizardCustomizationService_CustomizeReportWizard(ByVal tool As IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeReportWizard
            ' Redefine the start page.
            tool.RegisterPage(Of ChooseReportTypePageEx(Of XtraReportModel), ChoosePersonsPage)()

            ' Register the custom page.
            tool.RegisterPage(Of ChoosePersonsPage2(Of XtraReportModel), ChoosePersonsPage3)()

            ' Register the custom page view.
            tool.RegisterPageView(Of IChoosePersonsPageView, ChoosePersonsPageView2)()
        End Sub
        Private Function IWizardCustomizationService_TryCreateReport(ByVal designerHost As IDesignerHost, ByVal model As XtraReportModel, ByVal dataSource As Object, ByVal dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateReport
            Return False
        End Function
        Private Function IWizardCustomizationService_TryCreateDataSource(ByVal model As IDataSourceModel, ByRef dataSource As Object, ByRef dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateDataSource
            If model.DataSourceType Is CustomDataSourceType.StaticPersons Then
                dataMember = String.Empty
                dataSource = CreateObjectDataSource("GetStaticPersons")
                Return True
            ElseIf model.DataSourceType Is CustomDataSourceType.XmlPersons Then
                dataMember = String.Empty
                dataSource = CreateObjectDataSource("GetXmlPersons")
                Return True
            Else
                dataMember = String.Empty
                dataSource = Nothing
                Return False
            End If
        End Function
        Private Shared Function CreateObjectDataSource(ByVal dataMember As String) As ObjectDataSource
            Dim objectDataSource = New ObjectDataSource()
            objectDataSource.Constructor = New ObjectConstructorInfo()
            objectDataSource.DataMember = dataMember
            objectDataSource.DataSource = GetType(PersonsSource)
            objectDataSource.Name = "objectDataSource1"
            Return objectDataSource
        End Function
    End Class
    Public Class CustomDataSourceType
        Inherits DataSourceType

        Public Shared ReadOnly StaticPersons As DataSourceType = New CustomDataSourceType()
        Public Shared ReadOnly XmlPersons As DataSourceType = New CustomDataSourceType()
    End Class
End Namespace
