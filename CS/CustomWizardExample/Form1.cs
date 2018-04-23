using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace CustomWizardExample {
    public partial class Form1 : XRDesignRibbonForm {
        public Form1() {
            InitializeComponent();
            DesignMdiController.AddCommandHandler(new CustomWizardCommandHandler(DesignMdiController));
            DesignMdiController.CreateNewReport();
        }
    }
}
