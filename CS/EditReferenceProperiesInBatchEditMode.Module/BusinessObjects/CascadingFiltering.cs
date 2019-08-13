using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace EditReferenceProperiesInBatchEditMode.Module.BusinessObjects {
    [DefaultClassOptions]
    public class CascadeLookupBatch : BaseObject {
        public CascadeLookupBatch(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
        private Country country;
        [ImmediatePostData]
        public Country Country {
            get {
                return country;
            }

            set {
                SetPropertyValue(nameof(Country), ref country, value);
                City = null;
            }
        }
        private City city;
        [DataSourceProperty("Country.Cities")]
        public City City {
            get {
                return city;
            }

            set {
                SetPropertyValue(nameof(City), ref city, value);
            }
        }

    }
    public class Country : BaseObject {
        public Country(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
        [Association("Country-To-Cities")]
        public XPCollection<City> Cities {
            get { return GetCollection<City>(nameof(Cities)); }
        }
    }
    public class City : BaseObject {
        public City(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
        private Country country;
        [Association("Country-To-Cities")]
        public Country Country {
            get {
                return country;
            }

            set {
                SetPropertyValue(nameof(Country), ref country, value);
            }
        }
    }
}
