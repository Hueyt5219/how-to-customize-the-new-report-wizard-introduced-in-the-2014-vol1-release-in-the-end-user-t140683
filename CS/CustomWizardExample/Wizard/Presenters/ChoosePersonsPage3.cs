using System;
using CustomWizardExample.Wizard.Views;
using DevExpress.Data.WizardFramework;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.XtraReports.Wizards3;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsPage3 : ChoosePersonsPage2<XtraReportModel> {
        public ChoosePersonsPage3(Views.IChoosePersonsPageView view) : base(view) { }

        public override Type GetNextPageType() { return typeof(DevExpress.XtraReports.Wizards3.Presenters.SelectColumnsPage<XtraReportModel>); }
        public override bool MoveNextEnabled { get { return true; } }
        public override bool FinishEnabled { get { return false; } }
    }
}
