Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports CustomWizardExample.Wizard
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraReports.Wizards3

Namespace CustomWizardExample
	Partial Public Class Form1
		Inherits XRDesignRibbonForm
		Public Sub New()
			InitializeComponent()
			DesignMdiController.AddService(GetType(IWizardCustomizationService), New WizardCustomizationService())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			BeginInvoke(New MethodInvoker(AddressOf CreateNewReportWizard))
		End Sub
		Private Sub CreateNewReportWizard()
			DesignMdiController.CreateNewReportWizard()
		End Sub
	End Class
End Namespace
