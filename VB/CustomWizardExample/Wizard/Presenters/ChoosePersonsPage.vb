Imports System
Imports System.Collections.Generic
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Entity.ProjectModel
Imports DevExpress.XtraReports.Wizards
Imports DevExpress.XtraReports.Wizards.Presenters
Imports DevExpress.XtraReports.Wizards.Views

Namespace CustomWizardExample.Wizard.Presenters
    Friend Class ChoosePersonsPage
        Inherits ChooseReportTypePage(Of XtraReportModel)

        Public Sub New(ByVal view As IChooseReportTypePageView, ByVal connectionStorageService As IConnectionStorageService, ByVal dataSourceTypes As DataSourceTypes, ByVal context As IWizardRunnerContext, ByVal solutionTypesProvider As ISolutionTypesProvider)
            MyBase.New(view, connectionStorageService, dataSourceTypes, context, solutionTypesProvider)
        End Sub

        Public Overrides Function GetNextPageType() As Type
            Return If(View.ReportType = DevExpress.XtraReports.Wizards.ReportType.Standard, GetType(ChoosePersonsPage2(Of XtraReportModel)), MyBase.GetNextPageType())
        End Function
    End Class
End Namespace
