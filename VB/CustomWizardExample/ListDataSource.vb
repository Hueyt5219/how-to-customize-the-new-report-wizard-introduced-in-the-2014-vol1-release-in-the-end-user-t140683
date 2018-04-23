Imports System.Collections
Imports DevExpress.DataAccess.Native

Namespace CustomWizardExample
	Public Class ListDataSource
		Inherits ArrayList
		Implements IDataComponent

		Public Sub New(ByVal c As ICollection)
			MyBase.New(c)
		End Sub

		#Region "Implementation of IDataComponent"

		Public ReadOnly Property DataMember() As String Implements IDataComponent.DataMember
			Get
				Return String.Empty
			End Get
		End Property

		#End Region
	End Class
End Namespace
