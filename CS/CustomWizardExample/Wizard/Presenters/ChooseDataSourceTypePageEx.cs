using System;
using CustomWizardExample.Wizard.Model;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChooseDataSourceTypePageEx : ChooseDataSourceTypePage<Model.CustomReportModel, IDataSourceWizardClient> {
        public ChooseDataSourceTypePageEx(IChooseDataSourceTypePageView view, IDataSourceWizardClient client) : base(view, client) { }

        public override Type GetNextPageType() {
            if(View.DataSourceType == CustomDataSourceType.Persons)
                return typeof(ChoosePersonsDataSourceTypePage);
            return base.GetNextPageType();
        }
    }
}
