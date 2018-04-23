Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.XtraEditors

Namespace CustomWizardExample.Wizard.Views
    Partial Public Class ChoosePersonsPageView2
        Inherits WizardViewBase
        Implements IChoosePersonsPageView

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

        #Region "Implementation of IChoosePersonsPageView"

        Private Function IChoosePersonsPageView_ShowWarning() As Boolean Implements IChoosePersonsPageView.ShowWarning
            Return XtraMessageBox.Show(LookAndFeel, Me, "Persons from the static list will be used, OK ?", "Wizard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
        End Function

        Private Property IChooseDataSourceTypePageView_DataSourceType() As DataSourceType Implements IChooseDataSourceTypePageView.DataSourceType
            Get
                Return If(Me.rgDataSourceType.SelectedIndex = 0, CustomDataSourceType.XmlPersons, CustomDataSourceType.StaticPersons)
            End Get
            Set(ByVal value As DataSourceType)
                If value Is CustomDataSourceType.XmlPersons Then
                    Me.rgDataSourceType.SelectedIndex = 0
                Else
                    Me.rgDataSourceType.SelectedIndex = 1
                End If
            End Set
        End Property

        #End Region
    End Class
End Namespace
