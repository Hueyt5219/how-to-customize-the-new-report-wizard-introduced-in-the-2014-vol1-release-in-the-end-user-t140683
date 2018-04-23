namespace CustomWizardExample.Wizard.Views {
    partial class ChooseDataSourceTypePageViewEx {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.baseContentPanel)).BeginInit();
            this.baseContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(401, 205);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(490, 205);
            // 
            // separatorTop
            // 
            this.separatorTop.Size = new System.Drawing.Size(585, 3);
            // 
            // separatorBottom
            // 
            this.separatorBottom.Location = new System.Drawing.Point(0, 190);
            this.separatorBottom.Size = new System.Drawing.Size(585, 13);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(533, 13);
            // 
            // baseContentPanel
            // 
            this.baseContentPanel.Controls.Add(this.radioGroup1);
            this.baseContentPanel.Location = new System.Drawing.Point(2, 49);
            this.baseContentPanel.Size = new System.Drawing.Size(581, 141);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup1.Location = new System.Drawing.Point(0, 0);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Database"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Entity Framework"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "List of Persons")});
            this.radioGroup1.Size = new System.Drawing.Size(581, 84);
            this.radioGroup1.TabIndex = 1;
            // 
            // ChooseDataSourceTypePageViewEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChooseDataSourceTypePageViewEx";
            this.Size = new System.Drawing.Size(585, 239);
            ((System.ComponentModel.ISupportInitialize)(this.baseContentPanel)).EndInit();
            this.baseContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;

    }
}
