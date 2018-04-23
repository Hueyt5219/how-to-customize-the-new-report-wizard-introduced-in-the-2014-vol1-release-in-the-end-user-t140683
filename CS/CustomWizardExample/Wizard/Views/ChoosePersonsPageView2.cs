using System;
using System.Collections.Generic;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.UI.Wizard.Views;
using System.Windows.Forms;
using DevExpress.DataAccess.Wizard.Model;

namespace CustomWizardExample.Wizard.Views {
    public partial class ChoosePersonsPageView2 : WizardViewBase, IChoosePersonsPageView, IWizardPageView {
        public ChoosePersonsPageView2() {
            InitializeComponent();
        }

        #region Implementation of IWizardPageView

        public override string HeaderDescription { get { return "Select one of data lists below"; } }

        #endregion

        #region Implementation of IChoosePersonsPageView
        bool IChoosePersonsPageView.ShowWarning() {
            return XtraMessageBox.Show(LookAndFeel, this, "Persons from the static list will be used, OK ?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        DataSourceType IChooseDataSourceTypePageView.DataSourceType {
            get {         
                return this.rgDataSourceType.SelectedIndex == 0 ? CustomDataSourceType.XmlPersons : CustomDataSourceType.StaticPersons; 
            } 
            set {
                if(value == CustomDataSourceType.XmlPersons)
                    this.rgDataSourceType.SelectedIndex = 0;
                else
                    this.rgDataSourceType.SelectedIndex = 1;
            }
        }
        #endregion
    }
}
