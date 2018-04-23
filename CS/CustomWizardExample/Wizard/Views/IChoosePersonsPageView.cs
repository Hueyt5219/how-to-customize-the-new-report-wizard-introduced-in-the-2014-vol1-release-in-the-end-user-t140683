using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Wizard.Views;

namespace CustomWizardExample.Wizard.Views {
    public interface IChoosePersonsPageView : IChooseDataSourceTypePageView {
        bool ShowWarning();
    }
}
