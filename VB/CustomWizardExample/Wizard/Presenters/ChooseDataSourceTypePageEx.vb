Imports System
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.DataAccess.Sql

Namespace CustomWizardExample.Wizard.Presenters
    Public Class ChooseDataSourceTypePageEx
        Inherits ChooseDataSourceTypePage(Of Model.CustomReportModel)

        Public Sub New(ByVal view As IChooseDataSourceTypePageView, ByVal connections As IEnumerable(Of SqlDataConnection))
            MyBase.New(view, connections)
        End Sub

        Public Overrides Function GetNextPageType() As Type
            If View.DataSourceType Is CustomDataSourceType.Persons Then
                Return GetType(ChoosePersonsDataSourceTypePage)
            End If
            Return MyBase.GetNextPageType()
        End Function
    End Class
End Namespace
