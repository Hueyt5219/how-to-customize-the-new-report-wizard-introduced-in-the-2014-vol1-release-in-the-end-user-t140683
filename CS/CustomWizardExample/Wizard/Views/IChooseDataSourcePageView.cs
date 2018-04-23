using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWizardExample.Wizard.Views {
    public interface IChoosePersonsDataSourcePageView {
        PersonsDataSourceType DataSourceType { get; set; }
        bool ShowWarning();
    }
}
