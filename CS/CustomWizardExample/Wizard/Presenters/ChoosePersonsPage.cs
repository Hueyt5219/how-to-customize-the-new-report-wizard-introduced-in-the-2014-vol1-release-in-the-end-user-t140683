using System;
using System.Collections.Generic;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Entity.ProjectModel;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraReports.Wizards.Presenters;
using DevExpress.XtraReports.Wizards.Views;

namespace CustomWizardExample.Wizard.Presenters {
    class ChoosePersonsPage : ChooseReportTypePage<XtraReportModel> {
        public ChoosePersonsPage(IChooseReportTypePageView view, IConnectionStorageService connectionStorageService, 
            DataSourceTypes dataSourceTypes, IWizardRunnerContext context, ISolutionTypesProvider solutionTypesProvider)
            : base(view, connectionStorageService, dataSourceTypes, context, solutionTypesProvider) {
        }

        public override Type GetNextPageType() {
            return (View.ReportType == DevExpress.XtraReports.Wizards.ReportType.Standard)
                ? typeof(ChoosePersonsPage2<XtraReportModel>)
                : base.GetNextPageType();
        }
    }
}
