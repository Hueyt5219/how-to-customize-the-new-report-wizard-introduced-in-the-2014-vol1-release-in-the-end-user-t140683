Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomWizardExample.Wizard.Views
	Public Interface IChoosePersonsDataSourcePageView
		Property DataSourceType() As PersonsDataSourceType
		Function ShowWarning() As Boolean
	End Interface
End Namespace
