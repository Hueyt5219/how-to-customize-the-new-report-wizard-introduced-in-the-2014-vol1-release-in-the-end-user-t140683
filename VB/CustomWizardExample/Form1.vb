Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner

Namespace CustomWizardExample
	Partial Public Class Form1
		Inherits XRDesignRibbonForm

		Public Sub New()
			InitializeComponent()
			DesignMdiController.AddCommandHandler(New CustomWizardCommandHandler(DesignMdiController))
			DesignMdiController.CreateNewReport()
		End Sub
	End Class
End Namespace
