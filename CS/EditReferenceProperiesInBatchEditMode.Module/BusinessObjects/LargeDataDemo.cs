using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace EditReferenceProperiesInBatchEditMode.Module.BusinessObjects {
    [DefaultClassOptions]
    public class LargeDataDemo : BaseObject {
        public LargeDataDemo(Session session) : base(session) { }
        private string name;
        public string Name {
            get {
                return name;
            }

            set {
                SetPropertyValue<string>(nameof(Name), ref name, value);
            }
        }
        private LargeData largeData;
        public LargeData LargeData {
            get {
                return largeData;
            }

            set {
                SetPropertyValue(nameof(LargeData), ref largeData, value);
            }
        }
    }
    public class LargeData : BaseObject {
        public LargeData(Session session) : base(session) { }
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
