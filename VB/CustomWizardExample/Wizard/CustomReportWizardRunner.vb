Imports System.Windows.Forms
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.Wizards3

Namespace CustomWizardExample.Wizard
	Public Class CustomReportWizardRunner
		Inherits XtraReportWizardRunner(Of Model.CustomReportModel, IDataSourceWizardClient)

		Public Sub New(ByVal lookAndFeel As UserLookAndFeel, ByVal owner As IWin32Window)
            MyBase.New(lookAndFeel, owner)
		End Sub

		Protected Overrides Function CreatePageFactory(ByVal client As IDataSourceWizardClient) As WizardPageFactoryBase(Of CustomReportModel, IDataSourceWizardClient)
			Return New CustomReportWizardPageFactory(client)
		End Function

	End Class
End Namespace
