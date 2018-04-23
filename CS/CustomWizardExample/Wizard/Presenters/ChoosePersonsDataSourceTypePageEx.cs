using CustomWizardExample.Wizard.Views;
using DevExpress.DataAccess.Wizard;

namespace CustomWizardExample.Wizard.Presenters {
    public class ChoosePersonsDataSourceTypePageEx : ChoosePersonsDataSourceTypePage {
        public ChoosePersonsDataSourceTypePageEx(IChoosePersonsDataSourcePageView view, IDataSourceWizardClient client) : base(view, client) { }

        public override bool MoveNextEnabled { get { return false; } }

        public override bool FinishEnabled { get { return base.MoveNextEnabled; } }

    }
}
