Imports Microsoft.VisualBasic
Imports System
Namespace CustomWizardExample.Wizard.Views
	Partial Public Class ChoosePersonsPageView2
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.rgDataSourceType = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.baseContentPanel.SuspendLayout()
			CType(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nextButton
			' 
			Me.nextButton.Location = New System.Drawing.Point(313, 418)
			Me.nextButton.Size = New System.Drawing.Size(59, 22)
			' 
			' finishButton
			' 
			Me.finishButton.Location = New System.Drawing.Point(378, 418)
			Me.finishButton.Size = New System.Drawing.Size(58, 22)
			' 
			' separatorTop
			' 
			Me.separatorTop.Size = New System.Drawing.Size(448, 6)
			' 
			' separatorBottom
			' 
			Me.separatorBottom.Location = New System.Drawing.Point(0, 403)
			Me.separatorBottom.Size = New System.Drawing.Size(448, 13)
			' 
			' headerLabel
			' 
			Me.headerLabel.Size = New System.Drawing.Size(396, 13)
			' 
			' baseContentPanel
			' 
			Me.baseContentPanel.Controls.Add(Me.rgDataSourceType)
			Me.baseContentPanel.Size = New System.Drawing.Size(444, 351)
			' 
			' rgDataSourceType
			' 
			Me.rgDataSourceType.Dock = System.Windows.Forms.DockStyle.Top
			Me.rgDataSourceType.Location = New System.Drawing.Point(0, 0)
			Me.rgDataSourceType.Name = "rgDataSourceType"
			Me.rgDataSourceType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Load data from the xml file"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Load data from the predefined list")})
			Me.rgDataSourceType.Size = New System.Drawing.Size(444, 96)
			Me.rgDataSourceType.TabIndex = 3
			' 
			' ChoosePersonsPageView2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "ChoosePersonsPageView2"
			Me.Size = New System.Drawing.Size(448, 452)
			CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.baseContentPanel.ResumeLayout(False)
			CType(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rgDataSourceType As DevExpress.XtraEditors.RadioGroup



	End Class
End Namespace
