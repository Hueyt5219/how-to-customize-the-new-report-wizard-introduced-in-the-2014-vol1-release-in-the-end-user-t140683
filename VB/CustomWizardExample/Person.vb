Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Linq

Namespace CustomWizardExample
    Public Class Person
        <DisplayName("First Name")> _
        Public Property FirstName() As String
        <DisplayName("Second Name")> _
        Public Property SecondName() As String
    End Class
    Public Class PersonsSource
        Public Function GetXmlPersons() As IList(Of Person)
            Dim root = System.Xml.Linq.XDocument.Load("Data.xml").Root
            Dim persons As New List(Of Person)()
            For Each item In root.Elements()
                Dim firstName = GetAttributeValue(item, "FirstName")
                Dim secondName = GetAttributeValue(item, "SecondName")

                Dim person = New Person() With {.FirstName = firstName, .SecondName = secondName}
                persons.Add(person)
            Next item
            Return persons
        End Function
        Private Shared Function GetAttributeValue(ByVal element As XElement, ByVal attributeName As String) As String
            Dim attrbute As XAttribute = element.Attribute(attributeName)
            Return If(attrbute Is Nothing, Nothing, attrbute.Value)
        End Function
        Public Function GetStaticPersons() As IList(Of Person)
            Return New List(Of Person)( { _
                New Person() With {.FirstName = "John", .SecondName = "Abbot"}, _
                New Person() With {.FirstName = "Paul", .SecondName = "Bass"}, _
                New Person() With {.FirstName = "George", .SecondName = "Chance"} _
            })
        End Function
    End Class
End Namespace
