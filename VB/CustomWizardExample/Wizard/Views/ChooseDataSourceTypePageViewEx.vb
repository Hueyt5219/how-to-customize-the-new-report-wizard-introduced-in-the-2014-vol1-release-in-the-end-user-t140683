Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CustomWizardExample.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.XtraEditors

Namespace CustomWizardExample.Wizard.Views
	Partial Public Class ChooseDataSourceTypePageViewEx
		Inherits XtraUserControl
		Implements IChooseDataSourceTypePageView, IWizardPageView

		Private Shared ReadOnly dataSourceTypeValues As New List(Of DataSourceType)( { DataSourceType.Xpo, DataSourceType.Entity, CustomDataSourceType.Persons })

		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Implementation of IChooseDataSourceTypePageView"

		Public Property DataSourceType() As DataSourceType Implements IChooseDataSourceTypePageView.DataSourceType
			Get
				Return dataSourceTypeValues(radioGroup1.SelectedIndex)
			End Get
			Set(ByVal value As DataSourceType)
				radioGroup1.SelectedIndex = dataSourceTypeValues.IndexOf(value)
			End Set
		End Property

		#End Region

		#Region "Implementation of IWizardPageView"

		Public ReadOnly Property HeaderDescription() As String Implements IWizardPageView.HeaderDescription
			Get
				Return "Choose data source type"
			End Get
		End Property

		#End Region
	End Class
End Namespace
