Imports CustomWizardExample.Wizard.Views
Imports DevExpress.DataAccess.Wizard

Namespace CustomWizardExample.Wizard.Presenters
	Public Class ChoosePersonsDataSourceTypePageEx
		Inherits ChoosePersonsDataSourceTypePage

        Public Sub New(ByVal view As IChoosePersonsDataSourcePageView)
            MyBase.New(view)
        End Sub

		Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
			Get
				Return False
			End Get
		End Property

		Public Overrides ReadOnly Property FinishEnabled() As Boolean
			Get
				Return MyBase.MoveNextEnabled
			End Get
		End Property

	End Class
End Namespace
