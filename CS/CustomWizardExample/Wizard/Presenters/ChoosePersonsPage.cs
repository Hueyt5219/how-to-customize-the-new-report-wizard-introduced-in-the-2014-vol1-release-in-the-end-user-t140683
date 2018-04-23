using System;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using System.Collections.Generic;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Views;
using DevExpress.Data.XtraReports.Wizard;

namespace CustomWizardExample.Wizard.Presenters {
    class ChoosePersonsPage : DevExpress.XtraReports.Wizards3.Presenters.ChooseReportTypePageEx<XtraReportModel> {
        public ChoosePersonsPage(IChooseReportTypePageViewExtended view) : base(view) { 
        }
        public override Type GetNextPageType() {
            return (View.ReportType == ReportType.Standard)
                ? typeof(ChoosePersonsPage2<XtraReportModel>)
                : base.GetNextPageType();
        }
    }
}
