using System;
using System.Collections.Generic;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Presenters;
using DevExpress.XtraReports.Wizards3.Views;

namespace CustomWizardExample.Wizard.Presenters {
    class ChoosePersonsPage : ChooseReportTypePageEx<XtraReportModel> {
        public ChoosePersonsPage(IChooseReportTypePageViewExtended view, IEnumerable<SqlDataConnection> dataConnections, DataSourceTypes dataSourceTypes)
            : base(view, dataConnections, dataSourceTypes) { 
        }
        public override Type GetNextPageType() {
            return (View.ReportType == ReportType.Standard)
                ? typeof(ChoosePersonsPage2<XtraReportModel>)
                : base.GetNextPageType();
        }
    }
}
