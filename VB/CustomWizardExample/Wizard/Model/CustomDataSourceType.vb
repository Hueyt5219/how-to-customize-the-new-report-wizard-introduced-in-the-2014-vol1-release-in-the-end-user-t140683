Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess.Wizard.Model

Namespace CustomWizardExample.Wizard.Model
	Public Class CustomDataSourceType
		Inherits DataSourceType

		Public Shared ReadOnly Persons As New CustomDataSourceType()
	End Class
End Namespace
