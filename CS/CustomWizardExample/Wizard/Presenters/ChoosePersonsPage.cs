using System;
using System.Collections.Generic;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Entity.ProjectModel;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Presenters;
using DevExpress.XtraReports.Wizards3.Views;

namespace CustomWizardExample.Wizard.Presenters {
    class ChoosePersonsPage : ChooseReportTypePageEx<XtraReportModel> {
        public ChoosePersonsPage(IChooseReportTypePageViewExtended view, IEnumerable<SqlDataConnection> dataConnections, DataSourceTypes dataSourceTypes, IWizardRunnerContext context, ISolutionTypesProvider solutionTypesProvider)
            : base(view, dataConnections, dataSourceTypes, context, solutionTypesProvider) {
        }

        public override Type GetNextPageType() {
            return (View.ReportType == ReportType.Standard)
                ? typeof(ChoosePersonsPage2<XtraReportModel>)
                : base.GetNextPageType();
        }
    }
}
