Imports CustomWizardExample.Wizard.Presenters
Imports CustomWizardExample.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.XtraReports.Wizards3

Namespace CustomWizardExample.Wizard
	Friend Class WizardCustomizationService
		Implements IWizardCustomizationService
		Private Sub CustomizeDataSourceWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of DevExpress.DataAccess.Wizard.Model.DataSourceModel)) Implements IWizardCustomizationService.CustomizeDataSourceWizard
			' set the start page
			tool.StartPage = GetType(ChoosePersonsPage2(Of DataSourceModel))

			' register the custom page
			tool.RegisterPage(Of ChoosePersonsPage2(Of DataSourceModel), ChoosePersonsPage2(Of DataSourceModel))()

			' register the custom page view
			tool.RegisterPageView(Of IChoosePersonsPageView, ChoosePersonsPageView2)()
		End Sub
		Private Sub CustomizeReportWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeReportWizard
			' redefine the start page
			tool.RegisterPage(Of DevExpress.XtraReports.Wizards3.Presenters.ChooseReportTypePageEx(Of XtraReportModel), ChoosePersonsPage)()

			' register the custom page
			tool.RegisterPage(Of ChoosePersonsPage2(Of XtraReportModel), ChoosePersonsPage3)()

			' register the custom page view
			tool.RegisterPageView(Of IChoosePersonsPageView, ChoosePersonsPageView2)()
		End Sub
		Private Function TryCreateReport(ByVal designerHost As System.ComponentModel.Design.IDesignerHost, ByVal model As XtraReportModel, ByVal dataSource As Object, ByVal dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateReport
			Return False
		End Function
		Private Function TryCreateDataSource(ByVal model As IDataSourceModel, <System.Runtime.InteropServices.Out()> ByRef dataSource As Object, <System.Runtime.InteropServices.Out()> ByRef dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateDataSource
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
		Private Shared Function CreateObjectDataSource(ByVal dataMember As String) As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
			Dim objectDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource()
			objectDataSource.Constructor = New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
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
