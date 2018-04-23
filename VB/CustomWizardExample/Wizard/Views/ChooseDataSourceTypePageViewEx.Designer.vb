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
            CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.baseContentPanel.SuspendLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'nextButton
            '
            Me.nextButton.Location = New System.Drawing.Point(409, 205)
            Me.nextButton.Size = New System.Drawing.Size(79, 22)
            '
            'finishButton
            '
            Me.finishButton.Location = New System.Drawing.Point(494, 205)
            Me.finishButton.Size = New System.Drawing.Size(79, 22)
            '
            'separatorTop
            '
            Me.separatorTop.Size = New System.Drawing.Size(585, 3)
            '
            'separatorBottom
            '
            Me.separatorBottom.Location = New System.Drawing.Point(0, 190)
            Me.separatorBottom.Size = New System.Drawing.Size(585, 13)
            '
            'headerLabel
            '
            Me.headerLabel.Size = New System.Drawing.Size(533, 13)
            '
            'baseContentPanel
            '
            Me.baseContentPanel.Controls.Add(Me.radioGroup1)
            Me.baseContentPanel.Location = New System.Drawing.Point(2, 49)
            Me.baseContentPanel.Size = New System.Drawing.Size(581, 141)
            '
            'radioGroup1
            '
            Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radioGroup1.Location = New System.Drawing.Point(0, 0)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Database"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Entity Framework"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "List of Persons")})
            Me.radioGroup1.Size = New System.Drawing.Size(581, 84)
            Me.radioGroup1.TabIndex = 1
            '
            'ChooseDataSourceTypePageViewEx
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ChooseDataSourceTypePageViewEx"
            Me.Size = New System.Drawing.Size(585, 239)
            CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.baseContentPanel.ResumeLayout(False)
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup

		#End Region

    End Class
End Namespace
