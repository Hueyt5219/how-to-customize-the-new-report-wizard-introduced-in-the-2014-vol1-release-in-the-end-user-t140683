Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Data.WizardFramework
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.XtraReports.Wizards3
Imports DevExpress.XtraReports.Wizards3.Presenters

Namespace CustomWizardExample.Wizard.Presenters
	Public Class ChoosePersonsPage2(Of TModel As DevExpress.DataAccess.Wizard.Model.IDataSourceModel)
		Inherits WizardPageBase(Of Views.IChoosePersonsPageView, TModel)

		Public Sub New(ByVal view As Views.IChoosePersonsPageView)
			MyBase.New(view)
		End Sub
		Public Overrides Sub Begin()
			View.DataSourceType = CustomDataSourceType.XmlPersons
		End Sub
		Public Overrides Function Validate(<System.Runtime.InteropServices.Out()> ByRef errorMessage As String) As Boolean
			errorMessage = String.Empty
			If View.DataSourceType Is CustomDataSourceType.StaticPersons Then
				Return View.ShowWarning()
			End If
			Return True
		End Function
		Public Overrides Sub Commit()
			Model.DataSourceType = View.DataSourceType
			Model.DataSchema = New Person()
		End Sub
		Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Overrides ReadOnly Property FinishEnabled() As Boolean
			Get
				Return True
			End Get
		End Property
	End Class
End Namespace
