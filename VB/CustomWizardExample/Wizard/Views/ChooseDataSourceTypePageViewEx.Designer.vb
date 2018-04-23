Namespace CustomWizardExample.Wizard.Views
	Partial Public Class ChooseDataSourceTypePageViewEx
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
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radioGroup1.Location = New System.Drawing.Point(0, 0)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Size = New System.Drawing.Size(585, 84)
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
    New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Database"),
    New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Entity Framework"),
    New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "List of Persons")
   })
			Me.radioGroup1.TabIndex = 0
			' 
			' ChooseDataSourceTypePageViewEx
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radioGroup1)
			Me.Name = "ChooseDataSourceTypePageViewEx"
			Me.Size = New System.Drawing.Size(585, 239)
			DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace
