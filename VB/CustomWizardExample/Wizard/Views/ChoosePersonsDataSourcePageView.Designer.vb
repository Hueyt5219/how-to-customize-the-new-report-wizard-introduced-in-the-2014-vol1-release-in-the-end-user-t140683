Namespace CustomWizardExample.Wizard.Views
	Partial Public Class ChoosePersonsDataSourcePageView
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
			DirectCast(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rgDataSourceType
			' 
			Me.rgDataSourceType.Dock = System.Windows.Forms.DockStyle.Top
			Me.rgDataSourceType.Location = New System.Drawing.Point(0, 0)
			Me.rgDataSourceType.Name = "rgDataSourceType"
            Me.rgDataSourceType.Size = New System.Drawing.Size(448, 96)
            Me.rgDataSourceType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
				New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Load Persons from Data.xml"),
				New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Use static list of Persons from the application")
			})
			Me.rgDataSourceType.TabIndex = 2
			' 
			' ChoosePersonsDataSourcePageView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.rgDataSourceType)
			Me.Name = "ChoosePersonsDataSourcePageView"
			Me.Size = New System.Drawing.Size(448, 452)
			DirectCast(Me.rgDataSourceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rgDataSourceType As DevExpress.XtraEditors.RadioGroup


	End Class
End Namespace
