Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views

Namespace CustomWizardExample.Wizard
	Public Class CustomDataSourceWizardPageFactory
		Inherits WizardPageFactory(Of Model.CustomReportModel, IDataSourceWizardClient)

		Public Sub New(ByVal client As IDataSourceWizardClient)
			MyBase.New(client)
		End Sub


        Protected Overrides Sub RegisterDependencies(client As IDataSourceWizardClient)
            MyBase.RegisterDependencies(client)

            Container.RegisterType(Of ChooseDataSourceTypePage(Of Model.CustomReportModel), Presenters.ChooseDataSourceTypePageEx)()

            Container.RegisterType(Of IChooseDataSourceTypePageView, Views.ChooseDataSourceTypePageViewEx)()

            Container.RegisterType(Of Presenters.ChoosePersonsDataSourceTypePage, Presenters.ChoosePersonsDataSourceTypePageEx)()
            Container.RegisterType(Of Views.IChoosePersonsDataSourcePageView, Views.ChoosePersonsDataSourcePageView)()
        End Sub
	End Class
End Namespace
