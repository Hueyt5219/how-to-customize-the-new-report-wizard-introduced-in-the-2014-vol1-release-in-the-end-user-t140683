Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.UI.Wizard.Views

Namespace CustomWizardExample.Wizard.Views
    Partial Public Class ChoosePersonsDataSourcePageView
        Inherits WizardViewBase
        Implements IChoosePersonsDataSourcePageView, IWizardPageView

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "Implementation of IWizardPageView"

        Public Overrides ReadOnly Property HeaderDescription() As String
            Get
                Return "Select one of data lists below"
            End Get
        End Property

#End Region


        Public Function ShowWarning() As Boolean Implements IChoosePersonsDataSourcePageView.ShowWarning
            Return XtraMessageBox.Show(LookAndFeel, Me, "Persons from the static list will be used, OK ?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
        End Function

        Public Property DataSourceType() As PersonsDataSourceType Implements IChoosePersonsDataSourcePageView.DataSourceType
            Get
                Return If(Me.rgDataSourceType.SelectedIndex = 0, PersonsDataSourceType.Xml, PersonsDataSourceType.Static)
            End Get
            Set(ByVal value As PersonsDataSourceType)
                If value = PersonsDataSourceType.Xml Then
                    Me.rgDataSourceType.SelectedIndex = 0
                Else
                    Me.rgDataSourceType.SelectedIndex = 1
                End If
            End Set
        End Property
    End Class
End Namespace
