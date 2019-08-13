using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using EditReferenceProperiesInBatchEditMode.Module.BusinessObjects;

namespace EditReferenceProperiesInBatchEditMode.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            ImmediatePostDataDemo johnNilsen = ObjectSpace.FindObject<ImmediatePostDataDemo>(CriteriaOperator.Parse("LastName == ?", "Nilsen"));
            if(johnNilsen == null) {
                johnNilsen = ObjectSpace.CreateObject<ImmediatePostDataDemo>();
                johnNilsen.LastName = "Nilsen";
                johnNilsen.FirstName = "John";
                johnNilsen.BooleanProperty = true;
                johnNilsen.NumericProperty = 12;
            }
            ImmediatePostDataDemo maryTellitson = ObjectSpace.FindObject<ImmediatePostDataDemo>(CriteriaOperator.Parse("LastName == ?", "Tellitson"));
            if(maryTellitson == null) {
                maryTellitson = ObjectSpace.CreateObject<ImmediatePostDataDemo>();
                maryTellitson.LastName = "Tellitson";
                maryTellitson.FirstName = "Mary";
                maryTellitson.BooleanProperty = false;
                maryTellitson.NumericProperty = 15;
            }
            SimpleDemo simpleDemoObj = ObjectSpace.FindObject<SimpleDemo>(CriteriaOperator.Parse("Name == ?", "SimpleDemoObject1"));
            if(simpleDemoObj == null) {
                for(int i = 1; i < 5; i++) {
                    SimpleData simpleData = ObjectSpace.CreateObject<SimpleData>();
                    simpleData.Name = $"SimpleData{i}";
                    simpleDemoObj = ObjectSpace.CreateObject<SimpleDemo>();
                    simpleDemoObj.Name = $"SimpleDemoObject{i}";
                    simpleDemoObj.Data = simpleData;
                }
            }
            BusinessObjects.Country c = ObjectSpace.FindObject<BusinessObjects.Country>(CriteriaOperator.Parse("Name == ?", "France"));
            if(c == null) {
                c = ObjectSpace.CreateObject<BusinessObjects.Country>();
                c.Name = "France";
                City city = ObjectSpace.CreateObject<City>();
                city.Name = "Paris";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Lyon";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Marseille";
                c.Cities.Add(city);

                c = ObjectSpace.CreateObject<BusinessObjects.Country>();
                c.Name = "USA";
                city = ObjectSpace.CreateObject<City>();
                city.Name = "New York";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Los Angeles";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Seattle";
                c.Cities.Add(city);

                CascadeLookupBatch cascadeLookup = ObjectSpace.CreateObject<CascadeLookupBatch>();
                cascadeLookup.Name = "Route 1";
                cascadeLookup.Country = c;
                cascadeLookup.City = city;

                c = ObjectSpace.CreateObject<BusinessObjects.Country>();
                c.Name = "Italy";
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Rome";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Milan";
                c.Cities.Add(city);
                city = ObjectSpace.CreateObject<City>();
                city.Name = "Venice";
                c.Cities.Add(city);

                cascadeLookup = ObjectSpace.CreateObject<CascadeLookupBatch>();
                cascadeLookup.Name = "Route 2";
                cascadeLookup.Country = c;
                cascadeLookup.City = city;
            }
            ObjectSpace.CommitChanges();

            LargeDataDemo largeDataDemoObject = ObjectSpace.FindObject<LargeDataDemo>(CriteriaOperator.Parse("Name == ?", "LargeDataDemoObject"));
            if (largeDataDemoObject == null) {
                for (int i = 1; i < 100000; i++) {
                    LargeData obj1 = ObjectSpace.CreateObject<LargeData>();
                    obj1.Name = "LargeData" + i;
                    if (i == 150) {
                        LargeDataDemo largeDataDemo = ObjectSpace.CreateObject<LargeDataDemo>();
                        largeDataDemo.LargeData = obj1;
                        largeDataDemo.Name = "LargeDataDemoObject";
                    }
                    if (i % 1000 == 0) {
                        ObjectSpace.CommitChanges();
                    }
                }
            }
            ObjectSpace.CommitChanges();
        }
    }
}
