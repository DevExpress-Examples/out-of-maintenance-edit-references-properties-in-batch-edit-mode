Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl

' For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
Public Class Updater
    Inherits ModuleUpdater

    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub

    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()
        Dim johnNilsen As ImmediatePostDataDemo = ObjectSpace.FindObject(Of ImmediatePostDataDemo)(CriteriaOperator.Parse("LastName == ?", "Nilsen"))

        If johnNilsen Is Nothing Then
            johnNilsen = ObjectSpace.CreateObject(Of ImmediatePostDataDemo)()
            johnNilsen.LastName = "Nilsen"
            johnNilsen.FirstName = "John"
            johnNilsen.BooleanProperty = True
            johnNilsen.NumericProperty = 12
        End If

        Dim maryTellitson As ImmediatePostDataDemo = ObjectSpace.FindObject(Of ImmediatePostDataDemo)(CriteriaOperator.Parse("LastName == ?", "Tellitson"))

        If maryTellitson Is Nothing Then
            maryTellitson = ObjectSpace.CreateObject(Of ImmediatePostDataDemo)()
            maryTellitson.LastName = "Tellitson"
            maryTellitson.FirstName = "Mary"
            maryTellitson.BooleanProperty = False
            maryTellitson.NumericProperty = 15
        End If

        Dim simpleDemoObj As SimpleDemo = ObjectSpace.FindObject(Of SimpleDemo)(CriteriaOperator.Parse("Name == ?", "SimpleDemoObject1"))

        If simpleDemoObj Is Nothing Then

            For i As Integer = 1 To 5 - 1
                Dim simpleData As SimpleData = ObjectSpace.CreateObject(Of SimpleData)()
                simpleData.Name = $"SimpleData{i}"
                simpleDemoObj = ObjectSpace.CreateObject(Of SimpleDemo)()
                simpleDemoObj.Name = $"SimpleDemoObject{i}"
                simpleDemoObj.Data = simpleData
            Next
        End If

        Dim c As Country = ObjectSpace.FindObject(Of Country)(CriteriaOperator.Parse("Name == ?", "France"))

        If c Is Nothing Then
            c = ObjectSpace.CreateObject(Of Country)()
            c.Name = "France"
            Dim city As City = ObjectSpace.CreateObject(Of City)()
            city.Name = "Paris"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Lyon"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Marseille"
            c.Cities.Add(city)
            c = ObjectSpace.CreateObject(Of Country)()
            c.Name = "USA"
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "New York"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Los Angeles"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Seattle"
            c.Cities.Add(city)
            Dim cascadeLookup As CascadeLookupBatch = ObjectSpace.CreateObject(Of CascadeLookupBatch)()
            cascadeLookup.Name = "Route 1"
            cascadeLookup.Country = c
            cascadeLookup.City = city
            c = ObjectSpace.CreateObject(Of Country)()
            c.Name = "Italy"
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Rome"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Milan"
            c.Cities.Add(city)
            city = ObjectSpace.CreateObject(Of City)()
            city.Name = "Venice"
            c.Cities.Add(city)
            cascadeLookup = ObjectSpace.CreateObject(Of CascadeLookupBatch)()
            cascadeLookup.Name = "Route 2"
            cascadeLookup.Country = c
            cascadeLookup.City = city
        End If

        ObjectSpace.CommitChanges()

        Dim largeDataDemoObject As LargeDataDemo = ObjectSpace.FindObject(Of LargeDataDemo)(CriteriaOperator.Parse("Name == ?", "LargeDataDemoObject"))

        If largeDataDemoObject Is Nothing Then

            For i As Integer = 1 To 100000 - 1
                Dim obj1 As LargeData = ObjectSpace.CreateObject(Of LargeData)()
                obj1.Name = "LargeData" & i

                If i = 150 Then
                    Dim largeDataDemo As LargeDataDemo = ObjectSpace.CreateObject(Of LargeDataDemo)()
                    largeDataDemo.LargeData = obj1
                    largeDataDemo.Name = "LargeDataDemoObject"
                End If
                If i Mod 1000 = 0 Then
                    ObjectSpace.CommitChanges()
                End If
            Next
        End If
        ObjectSpace.CommitChanges()
    End Sub
End Class

