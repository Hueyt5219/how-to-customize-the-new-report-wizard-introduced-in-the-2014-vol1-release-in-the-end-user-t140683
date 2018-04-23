using System;
using System.Collections.Generic;
using DevExpress.Data.WizardFramework;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Presenters;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsPage2<TModel> : WizardPageBase<Views.IChoosePersonsPageView, TModel> 
        where TModel : DevExpress.DataAccess.Wizard.Model.IDataSourceModel {
        
        public ChoosePersonsPage2(Views.IChoosePersonsPageView view) : base(view) {
        }
        public override void Begin() {
            View.DataSourceType = CustomDataSourceType.XmlPersons;
        }
        public override bool Validate(out string errorMessage) {
            errorMessage = string.Empty;
            if(View.DataSourceType == CustomDataSourceType.StaticPersons)
                return View.ShowWarning();
            return true;
        }
        public override void Commit() {
            Model.DataSourceType = View.DataSourceType;
            Model.DataSchema = new Person();
        }
        public override bool MoveNextEnabled { get { return false; } }
        public override bool FinishEnabled { get { return true; } }
    }
}
