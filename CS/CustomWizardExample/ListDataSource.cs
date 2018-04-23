using System.Collections;
using DevExpress.DataAccess.Native;

namespace CustomWizardExample {
    public class ListDataSource : ArrayList, IDataComponent {
        public ListDataSource(ICollection c) : base(c) { }

        #region Implementation of IDataComponent

        public string DataMember { get { return string.Empty; } }

        #endregion
    }
}
