using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;
using CustomWizardExample.Wizard;
using CustomWizardExample.Wizard.Model;
using DevExpress.Data.Entity;
using DevExpress.DataAccess.EntityFramework.Native;
using DevExpress.DataAccess.Native;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Native;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Entity.ProjectModel;
using DevExpress.LookAndFeel;
using DevExpress.LookAndFeel.DesignService;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.Wizards3.Builder;

namespace CustomWizardExample {
    public class CustomWizardCommandHandler : ICommandHandler {
        XRDesignMdiController mdiController;

        public CustomWizardCommandHandler(XRDesignMdiController mdiController) {
            this.mdiController = mdiController;
        }

        #region Implementation of ICommandHandler

        public void HandleCommand(ReportCommand command, object[] args) {
            switch(command) {
                case ReportCommand.NewReportWizard:
                    OnNewReportWizard();
                    break;
                case ReportCommand.AddNewDataSource:
                    OnAddNewDataSource();
                    break;
            }
        }

        public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler) {
            useNextHandler = !(command == ReportCommand.NewReportWizard || command == ReportCommand.AddNewDataSource);
            return !useNextHandler;
        }

        #endregion

        void OnNewReportWizard() {
            mdiController.OpenReport(new XtraReport());

            IDesignerHost designerHost = mdiController.ActiveDesignPanel.GetService(typeof(IDesignerHost)) as IDesignerHost;
            Debug.Assert(designerHost != null, "host != null");

            CustomReportWizardRunner runner = CreateCustomReportWizardRunner(designerHost);
            DataSourceWizardClient client = CreateDataSourceWizardClient(designerHost);

            if(runner.Run(client) != DialogResult.OK)
                return;

            mdiController.Form.BeginInvoke(new MethodInvoker(() => {
                UndoEngine undoEngine = (UndoEngine)designerHost.GetService((typeof(UndoEngine)));
                System.Action myMethod = delegate() { new WizardReportBuilder(designerHost).Build(runner.WizardModel, true, CreateDataComponent(runner.WizardModel)); };
                undoEngine.ExecuteWithoutUndo(myMethod);
            }));
        }
        public void MyMethod(IDesignerHost designerHost, CustomReportWizardRunner runner) {
            new WizardReportBuilder(designerHost).Build(runner.WizardModel, true, CreateDataComponent(runner.WizardModel));
        }
        void OnAddNewDataSource() {
            IDesignerHost designerHost = mdiController.ActiveDesignPanel.GetService(typeof(IDesignerHost)) as IDesignerHost;
            Debug.Assert(designerHost != null, "host != null");

            CustomDataSourceWizardRunner runner = CreateCustomDataSourceWizardRunner(designerHost);
            DataSourceWizardClient client = CreateDataSourceWizardClient(designerHost);

            if(runner.Run(client) != DialogResult.OK)
                return;

            var dataComponent = CreateDataComponent(runner.WizardModel);

            if(dataComponent is IComponent) {
                DesignerTransaction designerTransaction = designerHost.CreateTransaction();
                designerHost.Container.Add((IComponent)dataComponent);
                designerTransaction.Commit();
            }
            XtraReport report = (XtraReport)designerHost.RootComponent;
            if(report.DataSource == null) {
                TypeDescriptor.GetProperties(report)["DataSource"].SetValue(report, dataComponent);
                TypeDescriptor.GetProperties(report)["DataMember"].SetValue(report, dataComponent.DataMember);
            }
        }

        static DataSourceWizardClient CreateDataSourceWizardClient(IDesignerHost host) {
            ISolutionTypesProvider solutionTypesProvider =
                EntityServiceHelper.GetRuntimeSolutionProvider(System.Reflection.Assembly.GetEntryAssembly());
            IConnectionStringsProvider connectionStringsProvider = new RuntimeConnectionStringsProvider();
            IConnectionStorageService connectionService = new ConnectionStorageService();
            IParameterService parameterService = (IParameterService)host.GetService(typeof(IParameterService));
            return new DataSourceWizardClient(connectionService, parameterService, solutionTypesProvider,
                connectionStringsProvider);
        }

        static CustomReportWizardRunner CreateCustomReportWizardRunner(IDesignerHost host) {
            UserLookAndFeel lookAndFeel =
                ((ILookAndFeelService)host.GetService(typeof(ILookAndFeelService))).LookAndFeel;
            IUIService uiService = (IUIService)host.GetService(typeof(IUIService));
            IWin32Window owner = uiService != null ? uiService.GetDialogOwnerWindow() : null;

            return new Wizard.CustomReportWizardRunner(lookAndFeel, owner);
        }

        static CustomDataSourceWizardRunner CreateCustomDataSourceWizardRunner(IDesignerHost host) {
            UserLookAndFeel lookAndFeel =
                ((ILookAndFeelService)host.GetService(typeof(ILookAndFeelService))).LookAndFeel;
            IUIService uiService = (IUIService)host.GetService(typeof(IUIService));
            IWin32Window owner = uiService != null ? uiService.GetDialogOwnerWindow() : null;

            return new Wizard.CustomDataSourceWizardRunner(lookAndFeel, owner);
        }

        static IDataComponent CreateDataComponent(CustomReportModel model) {
            if(model.DataSourceType == CustomDataSourceType.Persons) {
                if(model.PersonsDataSourceType == PersonsDataSourceType.Xml) {
                    var root = System.Xml.Linq.XDocument.Load("Data.xml").Root;
                    List<Person> persons = new List<Person>();
                    foreach(var item in root.Elements()) {
                        var firstName = item.GetAttributeValue("FirstName");
                        var secondName = item.GetAttributeValue("SecondName");

                        var person = new Person() { FirstName = firstName, SecondName = secondName };
                        persons.Add(person);
                    }
                    return new ListDataSource(persons);
                }
                else {
                    var staticPersons = new List<Person>(new[] { 
                        new Person() { FirstName = "John", SecondName = "Small" }, 
                        new Person() { FirstName = "Paul", SecondName = "Green" },
                        new Person() { FirstName = "George", SecondName = "White" }});
                    return new ListDataSource(staticPersons);
                }
            }
            return model.CreateDataComponent();
        }
    }
}
