using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace EditReferenceProperiesInBatchEditMode.Module.BusinessObjects {
    [DefaultClassOptions]
    public class ImmediatePostDataDemo : BaseObject {
        public ImmediatePostDataDemo(Session session) : base(session) { }
        private string lastName;
        [ImmediatePostData]
        public string LastName {
            get { return lastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref lastName, value); }
        }
        private string firstName;
        [ImmediatePostData]
        public string FirstName {
            get { return firstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref firstName, value); }
        }
        public string FullName {
            get { return $"{LastName} {FirstName}"; }
        }
        private bool booleanProperty;
        [ImmediatePostData]
        public bool BooleanProperty {
            get { return booleanProperty; }
            set { SetPropertyValue<bool>(nameof(BooleanProperty), ref booleanProperty, value); }
        }
        public string BooleanPropertyAsString {
            get { return $"{BooleanProperty.ToString()}"; }
        }
        private int numericProperty;
        [ImmediatePostData]
        public int NumericProperty {
            get { return numericProperty; }
            set { SetPropertyValue<int>(nameof(NumericProperty), ref numericProperty, value); }
        }
        public int SquaredNumericProperty {
            get { return NumericProperty * NumericProperty; }
        }
    }
}
