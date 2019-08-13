Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

<DefaultClassOptions>
Public Class ImmediatePostDataDemo
    Inherits BaseObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _lastName As String

    <ImmediatePostData>
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(NameOf(LastName), _lastName, value)
        End Set
    End Property

    Private _firstName As String

    <ImmediatePostData>
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(NameOf(FirstName), _firstName, value)
        End Set
    End Property

    Public ReadOnly Property FullName As String
        Get
            Return $"{LastName} {FirstName}"
        End Get
    End Property

    Private _booleanProperty As Boolean

    <ImmediatePostData>
    Public Property BooleanProperty As Boolean
        Get
            Return _booleanProperty
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)(NameOf(BooleanProperty), _booleanProperty, value)
        End Set
    End Property

    Public ReadOnly Property BooleanPropertyAsString As String
        Get
            Return $"{BooleanProperty.ToString()}"
        End Get
    End Property

    Private _numericProperty As Integer

    <ImmediatePostData>
    Public Property NumericProperty As Integer
        Get
            Return _numericProperty
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)(NameOf(NumericProperty), _numericProperty, value)
        End Set
    End Property

    Public ReadOnly Property SquaredNumericProperty As Integer
        Get
            Return NumericProperty * NumericProperty
        End Get
    End Property
End Class
