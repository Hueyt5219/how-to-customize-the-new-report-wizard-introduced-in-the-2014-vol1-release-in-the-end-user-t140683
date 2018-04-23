Imports System.Collections
Imports DevExpress.XtraReports.Wizards3

Namespace CustomWizardExample.Wizard.Model
	Public Class CustomReportModel
		Inherits XtraReportModel

		Public Sub New()
		End Sub

		Public Sub New(ByVal model As CustomReportModel)
			MyBase.New(model)
			PersonsDataSourceType = model.PersonsDataSourceType
		End Sub

		Public Property PersonsDataSourceType() As PersonsDataSourceType

		#Region "Overrides of XtraReportModel"

		Public Overrides Function Equals(ByVal obj As Object) As Boolean
			Dim another As CustomReportModel = TryCast(obj, CustomReportModel)
			If another Is Nothing Then
				Return False
			End If
			Return Me.PersonsDataSourceType = another.PersonsDataSourceType AndAlso MyBase.Equals(obj)
		End Function
		Public Overrides Function GetHashCode() As Integer
			Return MyBase.GetHashCode()
		End Function

		Public Overrides Function Clone() As Object
			Return New CustomReportModel(Me)
		End Function

		#End Region
	End Class
End Namespace
