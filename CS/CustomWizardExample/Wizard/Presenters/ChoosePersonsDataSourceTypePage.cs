using System;
using DevExpress.Data.WizardFramework;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Presenters;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsDataSourceTypePage : WizardPageBase<Views.IChoosePersonsDataSourcePageView, XtraReportModel> {
        public ChoosePersonsDataSourceTypePage(Views.IChoosePersonsDataSourcePageView view) : base(view) { }

        public override void Begin() {
            View.DataSourceType = PersonsDataSourceType.Xml;
        }

        public override bool Validate(out string errorMessage) {
            errorMessage = string.Empty;
            if(View.DataSourceType == PersonsDataSourceType.Static)
                return View.ShowWarning();
            return true;
        }


        public override void Commit() {
            Model.Tag = View.DataSourceType;
            Model.DataSchema = new Person();
        }

        public override Type GetNextPageType() { return typeof(SelectColumnsPage<XtraReportModel>); }
        public override bool MoveNextEnabled { get { return true; } }
       
    }
}
