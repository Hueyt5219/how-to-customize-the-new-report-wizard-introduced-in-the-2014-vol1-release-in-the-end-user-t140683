using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomWizardExample.Wizard.Model;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.UI.Wizard.Views;

namespace CustomWizardExample.Wizard.Views {
    public partial class ChooseDataSourceTypePageViewEx : WizardViewBase, IChooseDataSourceTypePageView, IWizardPageView {
        static readonly List<DataSourceType> dataSourceTypeValues = new List<DataSourceType>(new[] {
            DataSourceType.Xpo,
            DataSourceType.Entity,
            CustomDataSourceType.Persons
        });
        
        public ChooseDataSourceTypePageViewEx() {
            InitializeComponent();
        }

        #region Implementation of IChooseDataSourceTypePageView

        public DataSourceType DataSourceType {
            get { return dataSourceTypeValues[radioGroup1.SelectedIndex]; } 
            set { radioGroup1.SelectedIndex = dataSourceTypeValues.IndexOf(value); }
        }

        #endregion

        #region Implementation of IWizardPageView

        public override string HeaderDescription { get { return "Choose data source type"; } }

        #endregion
    }
}
