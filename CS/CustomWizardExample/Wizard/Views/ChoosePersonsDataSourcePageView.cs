using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraEditors;

namespace CustomWizardExample.Wizard.Views {
    public partial class ChoosePersonsDataSourcePageView : XtraUserControl, IChoosePersonsDataSourcePageView, IWizardPageView {
        public ChoosePersonsDataSourcePageView() {
            InitializeComponent();
        }

        #region Implementation of IWizardPageView

        public string HeaderDescription { get { return "Select one of data lists below"; } }

        #endregion


        public bool ShowWarning() {
            return XtraMessageBox.Show(LookAndFeel, this, "Persons from the static list will be used, OK ?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        public PersonsDataSourceType DataSourceType {
            get { return this.rgDataSourceType.SelectedIndex == 0 ? PersonsDataSourceType.Xml : PersonsDataSourceType.Static; } 
            set {
                if(value == PersonsDataSourceType.Xml)
                    this.rgDataSourceType.SelectedIndex = 0;
                else
                    this.rgDataSourceType.SelectedIndex = 1;
            } 
        }
    }
}
