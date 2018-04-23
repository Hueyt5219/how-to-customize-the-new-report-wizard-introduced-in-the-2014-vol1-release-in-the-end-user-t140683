Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess.Wizard.Views

Namespace CustomWizardExample.Wizard.Views
    Public Interface IChoosePersonsPageView
        Inherits IChooseDataSourceTypePageView

        Function ShowWarning() As Boolean
    End Interface
End Namespace
