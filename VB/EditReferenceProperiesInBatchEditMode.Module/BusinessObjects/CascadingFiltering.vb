Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

<DefaultClassOptions>
Public Class CascadeLookupBatch
    Inherits BaseObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(NameOf(Name), _name, value)
        End Set
    End Property

    Private _country As Country

    <ImmediatePostData>
    Public Property Country As Country
        Get
            Return _country
        End Get
        Set(ByVal value As Country)
            SetPropertyValue(NameOf(Country), _country, value)
            City = Nothing
        End Set
    End Property

    Private _city As City

    <DataSourceProperty("Country.Cities")>
    Public Property City As City
        Get
            Return _city
        End Get
        Set(ByVal value As City)
            SetPropertyValue(NameOf(City), _city, value)
        End Set
    End Property
End Class

Public Class Country
    Inherits BaseObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(NameOf(Name), _name, value)
        End Set
    End Property

    <Association("Country-To-Cities")>
    Public ReadOnly Property Cities As XPCollection(Of City)
        Get
            Return GetCollection(Of City)(NameOf(Cities))
        End Get
    End Property
End Class

Public Class City
    Inherits BaseObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _name As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)(NameOf(Name), _name, value)
        End Set
    End Property

    Private _country As Country

    <Association("Country-To-Cities")>
    Public Property Country As Country
        Get
            Return _country
        End Get
        Set(ByVal value As Country)
            SetPropertyValue(NameOf(Country), _country, value)
        End Set
    End Property
End Class
