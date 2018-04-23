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

        Public Property Name As String Implements IDataComponent.Name
            Get
                Return String.Empty
            End Get
            Set(value As String)
            End Set
        End Property

        Public Sub Fill(sourceParameters As System.Collections.Generic.IEnumerable(Of DevExpress.Data.IParameter)) Implements IDataComponent.Fill
        End Sub

        Public Sub LoadFromXml(element As System.Xml.Linq.XElement) Implements IDataComponent.LoadFromXml
        End Sub

        Public Function SaveToXml() As System.Xml.Linq.XElement Implements IDataComponent.SaveToXml
            Return Nothing
        End Function

#End Region
    End Class
End Namespace
