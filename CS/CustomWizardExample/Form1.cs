using System;
using System.Windows.Forms;
using CustomWizardExample.Wizard;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.Wizards3;

namespace CustomWizardExample {
    public partial class Form1 : XRDesignRibbonForm {
        public Form1() {
            InitializeComponent();
            DesignMdiController.AddService(typeof(IWizardCustomizationService), new WizardCustomizationService());
        }

        private void Form1_Load(object sender, EventArgs e) {
            BeginInvoke(new MethodInvoker(CreateNewReportWizard));
        }
        void CreateNewReportWizard() {
            DesignMdiController.CreateNewReportWizard();
        }
    }
}
