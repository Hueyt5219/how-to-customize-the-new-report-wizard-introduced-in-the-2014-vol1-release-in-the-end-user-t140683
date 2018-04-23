using System.Collections;
using DevExpress.XtraReports.Wizards3;

namespace CustomWizardExample.Wizard.Model {
    public class CustomReportModel : XtraReportModel {
        public CustomReportModel() { 
        }

        public CustomReportModel(CustomReportModel model) : base(model) {
            PersonsDataSourceType = model.PersonsDataSourceType;
        }

        public PersonsDataSourceType PersonsDataSourceType { get; set; }

        #region Overrides of XtraReportModel

        public override bool Equals(object obj) {
            CustomReportModel another = obj as CustomReportModel;
            if(another == null)
                return false;
            return this.PersonsDataSourceType == another.PersonsDataSourceType && base.Equals(obj);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override object Clone() { return new CustomReportModel(this); }

        #endregion
    }
}
