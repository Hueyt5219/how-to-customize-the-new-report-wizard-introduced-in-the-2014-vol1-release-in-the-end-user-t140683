using System;
using CustomWizardExample.Wizard.Model;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using System.Collections.Generic;
using DevExpress.DataAccess.Sql;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChooseDataSourceTypePageEx : ChooseDataSourceTypePage<Model.CustomReportModel> {
        public ChooseDataSourceTypePageEx(IChooseDataSourceTypePageView view, IEnumerable<SqlDataConnection> connections) : base(view, connections) { }

        public override Type GetNextPageType() {
            if(View.DataSourceType == CustomDataSourceType.Persons)
                return typeof(ChoosePersonsDataSourceTypePage);
            return base.GetNextPageType();
        }
    }
}
