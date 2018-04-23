using System.Windows.Forms;
using CustomWizardExample.Wizard.Model;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.Wizards3;

namespace CustomWizardExample.Wizard {
    public class CustomReportWizardRunner : XtraReportWizardRunner<Model.CustomReportModel, IDataSourceWizardClient> {
        public CustomReportWizardRunner(UserLookAndFeel lookAndFeel, IWin32Window owner) : base(lookAndFeel, owner) { }

        protected override WizardPageFactoryBase<CustomReportModel, IDataSourceWizardClient> CreatePageFactory(IDataSourceWizardClient client) { return new CustomReportWizardPageFactory(client); }

    }
}
