Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

<DefaultClassOptions>
Public Class LargeDataDemo
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

    Private _largeData As LargeData

    Public Property LargeData As LargeData
        Get
            Return _largeData
        End Get
        Set(ByVal value As LargeData)
            SetPropertyValue(NameOf(LargeData), _largeData, value)
        End Set
    End Property
End Class

Public Class LargeData
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
End Class
