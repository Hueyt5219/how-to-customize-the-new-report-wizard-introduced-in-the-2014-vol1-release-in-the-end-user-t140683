using System.Windows.Forms;
using CustomWizardExample.Wizard.Model;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard;
using DevExpress.LookAndFeel;

namespace CustomWizardExample.Wizard {
    public class CustomDataSourceWizardRunner : DevExpress.DataAccess.UI.Wizard.DataSourceWizardRunner<Model.CustomReportModel> {
        public CustomDataSourceWizardRunner(UserLookAndFeel lookAndFeel, IWin32Window owner) : base(lookAndFeel, owner) { }

        protected override WizardPageFactoryBase<CustomReportModel, IDataSourceWizardClient> CreatePageFactory(IDataSourceWizardClient client) { 
            return new CustomDataSourceWizardPageFactory(client); }
    }
}
