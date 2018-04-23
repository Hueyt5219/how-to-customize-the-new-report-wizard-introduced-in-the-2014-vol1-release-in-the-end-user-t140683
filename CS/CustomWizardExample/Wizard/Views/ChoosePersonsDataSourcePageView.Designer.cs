namespace CustomWizardExample.Wizard.Views {
    partial class ChoosePersonsDataSourcePageView {
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
            this.rgDataSourceType = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rgDataSourceType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rgDataSourceType
            // 
            this.rgDataSourceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgDataSourceType.Location = new System.Drawing.Point(0, 0);
            this.rgDataSourceType.Name = "rgDataSourceType";
            this.rgDataSourceType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Load Persons from Data.xml"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Use static list of Persons from the application")});
            this.rgDataSourceType.Size = new System.Drawing.Size(448, 96);
            this.rgDataSourceType.TabIndex = 2;
            // 
            // ChoosePersonsDataSourcePageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgDataSourceType);
            this.Name = "ChoosePersonsDataSourcePageView";
            this.Size = new System.Drawing.Size(448, 452);
            ((System.ComponentModel.ISupportInitialize)(this.rgDataSourceType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgDataSourceType;


    }
}
