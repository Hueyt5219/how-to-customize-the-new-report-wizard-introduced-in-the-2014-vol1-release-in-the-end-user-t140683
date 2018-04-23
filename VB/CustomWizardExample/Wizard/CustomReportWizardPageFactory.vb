Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.XtraReports.Wizards3

Namespace CustomWizardExample.Wizard
	Public Class CustomReportWizardPageFactory
		Inherits XtraReportWizardPageFactory(Of Model.CustomReportModel, IDataSourceWizardClient)

		Public Sub New(ByVal client As IDataSourceWizardClient)
			MyBase.New(client)
		End Sub

		Protected Overrides Sub RegisterDependencies()
			MyBase.RegisterDependencies()

			Container.RegisterType(Of ChooseDataSourceTypePage(Of Model.CustomReportModel, IDataSourceWizardClient), Presenters.ChooseDataSourceTypePageEx)()

			Container.RegisterType(Of IChooseDataSourceTypePageView, Views.ChooseDataSourceTypePageViewEx)()

			Container.RegisterType(Of Presenters.ChoosePersonsDataSourceTypePage)()
			Container.RegisterType(Of Views.IChoosePersonsDataSourcePageView, Views.ChoosePersonsDataSourcePageView)()
		End Sub

	End Class
End Namespace
