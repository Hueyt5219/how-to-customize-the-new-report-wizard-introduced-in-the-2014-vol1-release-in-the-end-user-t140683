using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Wizard.Model;

namespace CustomWizardExample.Wizard.Model {
    public class CustomDataSourceType : DataSourceType {
        public static readonly CustomDataSourceType Persons = new CustomDataSourceType();
    }
}
