Imports System
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.XtraReports.Wizards3.Presenters

Namespace CustomWizardExample.Wizard.Presenters
	Public Class ChoosePersonsDataSourceTypePage
        Inherits WizardPageBase(Of Views.IChoosePersonsDataSourcePageView, Model.CustomReportModel)

        Public Sub New(ByVal view As Views.IChoosePersonsDataSourcePageView)
            MyBase.New(view)
        End Sub

		Public Overrides Sub Begin()
			View.DataSourceType = Model.PersonsDataSourceType
		End Sub

		Public Overrides Function Validate(<System.Runtime.InteropServices.Out()> ByRef errorMessage As String) As Boolean
			errorMessage = String.Empty
			If View.DataSourceType = PersonsDataSourceType.Static Then
				Return View.ShowWarning()
			End If
			Return True
		End Function


		Public Overrides Sub Commit()
			Model.PersonsDataSourceType = View.DataSourceType
			Model.DataSchema = New Person()
		End Sub

		Public Overrides Function GetNextPageType() As Type
            Return GetType(SelectColumnsPage(Of Model.CustomReportModel))
		End Function
		Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
			Get
				Return True
			End Get
		End Property

	End Class
End Namespace
