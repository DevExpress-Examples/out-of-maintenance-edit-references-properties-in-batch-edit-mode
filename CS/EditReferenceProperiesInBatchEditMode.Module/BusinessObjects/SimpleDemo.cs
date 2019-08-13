using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace EditReferenceProperiesInBatchEditMode.Module.BusinessObjects {
    [DefaultClassOptions]
    public class SimpleDemo : BaseObject {
        public SimpleDemo(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
        private SimpleData data;
        public SimpleData Data {
            get {
                return data;
            }

            set {
                SetPropertyValue(nameof(Data), ref data, value);
            }
        }
    }
    public class SimpleData : BaseObject {
        public SimpleData(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
    }
}
