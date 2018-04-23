using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;

namespace CustomWizardExample.Wizard {
    public class CustomDataSourceWizardPageFactory : WizardPageFactory<Model.CustomReportModel, IDataSourceWizardClient> {
        public CustomDataSourceWizardPageFactory(IDataSourceWizardClient client) : base(client) { }


        protected override void RegisterDependencies() {
            base.RegisterDependencies();

            Container.RegisterType<ChooseDataSourceTypePage<Model.CustomReportModel, IDataSourceWizardClient>, Presenters.ChooseDataSourceTypePageEx>();

            Container.RegisterType<IChooseDataSourceTypePageView, Views.ChooseDataSourceTypePageViewEx>();

            Container.RegisterType<Presenters.ChoosePersonsDataSourceTypePage, Presenters.ChoosePersonsDataSourceTypePageEx>();
            Container.RegisterType<Views.IChoosePersonsDataSourcePageView, Views.ChoosePersonsDataSourcePageView>();
        }
    }
}
