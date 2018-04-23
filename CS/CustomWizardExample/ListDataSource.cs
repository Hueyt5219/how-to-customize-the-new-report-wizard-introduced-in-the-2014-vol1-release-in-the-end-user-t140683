using System.Collections;
using DevExpress.DataAccess.Native;

namespace CustomWizardExample {
    public class ListDataSource : ArrayList, IDataComponent {
        public ListDataSource(ICollection c) : base(c) { }

        #region Implementation of IDataComponent

        public string DataMember { get { return string.Empty; } }

        #endregion

        #region IDataComponent Members

        string IDataComponent.DataMember {
            get { return string.Empty; }
        }

        void IDataComponent.Fill(System.Collections.Generic.IEnumerable<DevExpress.Data.IParameter> sourceParameters) {
        }

        void IDataComponent.LoadFromXml(System.Xml.Linq.XElement element) {
        }

        string IDataComponent.Name {
            get {
                return string.Empty;
            }
            set {
            }
        }

        System.Xml.Linq.XElement IDataComponent.SaveToXml() {
            return null;
        }

        #endregion
    }
}
