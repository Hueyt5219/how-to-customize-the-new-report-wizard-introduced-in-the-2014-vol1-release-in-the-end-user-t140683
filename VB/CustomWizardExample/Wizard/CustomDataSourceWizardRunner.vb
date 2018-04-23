Imports System.Windows.Forms
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.LookAndFeel

Namespace CustomWizardExample.Wizard
	Public Class CustomDataSourceWizardRunner
		Inherits DevExpress.DataAccess.UI.Wizard.DataSourceWizardRunner(Of Model.CustomReportModel)

		Public Sub New(ByVal lookAndFeel As UserLookAndFeel, ByVal owner As IWin32Window)
			MyBase.New(lookAndFeel, owner)
		End Sub

		Protected Overrides Function CreatePageFactory(ByVal client As IDataSourceWizardClient) As WizardPageFactoryBase(Of CustomReportModel, IDataSourceWizardClient)
			Return New CustomDataSourceWizardPageFactory(client)
		End Function
	End Class
End Namespace
