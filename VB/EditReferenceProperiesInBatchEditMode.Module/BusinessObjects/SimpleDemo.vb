Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

<DefaultClassOptions>
Public Class SimpleDemo
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

    Private _data As SimpleData

    Public Property Data As SimpleData
        Get
            Return _data
        End Get
        Set(ByVal value As SimpleData)
            SetPropertyValue(NameOf(Data), _data, value)
        End Set
    End Property
End Class

Public Class SimpleData
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
