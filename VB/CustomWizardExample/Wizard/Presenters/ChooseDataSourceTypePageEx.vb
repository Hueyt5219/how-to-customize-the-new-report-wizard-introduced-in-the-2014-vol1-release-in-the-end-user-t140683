Imports System
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views

Namespace CustomWizardExample.Wizard.Presenters
	Public Class ChooseDataSourceTypePageEx
		Inherits ChooseDataSourceTypePage(Of Model.CustomReportModel, IDataSourceWizardClient)

		Public Sub New(ByVal view As IChooseDataSourceTypePageView, ByVal client As IDataSourceWizardClient)
			MyBase.New(view, client)
		End Sub

		Public Overrides Function GetNextPageType() As Type
			If View.DataSourceType Is CustomDataSourceType.Persons Then
				Return GetType(ChoosePersonsDataSourceTypePage)
			End If
			Return MyBase.GetNextPageType()
		End Function
	End Class
End Namespace
