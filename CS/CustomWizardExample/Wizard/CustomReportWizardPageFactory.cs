using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraReports.Wizards3;

namespace CustomWizardExample.Wizard {
    public class CustomReportWizardPageFactory : XtraReportWizardPageFactory<Model.CustomReportModel, IDataSourceWizardClient> {
        public CustomReportWizardPageFactory(IDataSourceWizardClient client) : base(client) { }

        protected override void RegisterDependencies() {
            base.RegisterDependencies();

            Container.RegisterType<ChooseDataSourceTypePage<Model.CustomReportModel, IDataSourceWizardClient>, Presenters.ChooseDataSourceTypePageEx>();

            Container.RegisterType<IChooseDataSourceTypePageView, Views.ChooseDataSourceTypePageViewEx>();

            Container.RegisterType<Presenters.ChoosePersonsDataSourceTypePage>();
            Container.RegisterType<Views.IChoosePersonsDataSourcePageView, Views.ChoosePersonsDataSourcePageView>();
        }

    }
}
