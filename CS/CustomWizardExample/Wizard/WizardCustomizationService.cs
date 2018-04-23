using System.ComponentModel.Design;
using CustomWizardExample.Wizard.Presenters;
using CustomWizardExample.Wizard.Views;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.XtraReports.Wizards3;
using DevExpress.XtraReports.Wizards3.Presenters;

namespace CustomWizardExample.Wizard {
    class WizardCustomizationService : IWizardCustomizationService {
        void IWizardCustomizationService.CustomizeDataSourceWizard(IWizardCustomization<XtraReportModel> tool) {
            // Set the start page.
            tool.StartPage = typeof(ChoosePersonsPage2<DataSourceModel>);

            // Register the custom page.
            tool.RegisterPage<ChoosePersonsPage2<XtraReportModel>, ChoosePersonsPage2<XtraReportModel>>();

            // Register the custom page view.
            tool.RegisterPageView<IChoosePersonsPageView, ChoosePersonsPageView2>();
        }
        void IWizardCustomizationService.CustomizeReportWizard(IWizardCustomization<XtraReportModel> tool) {
            // Redefine the start page.
            tool.RegisterPage<ChooseReportTypePageEx<XtraReportModel>, ChoosePersonsPage>();

            // Register the custom page.
            tool.RegisterPage<ChoosePersonsPage2<XtraReportModel>, ChoosePersonsPage3>();

            // Register the custom page view.
            tool.RegisterPageView<IChoosePersonsPageView, ChoosePersonsPageView2>();
        }
        bool IWizardCustomizationService.TryCreateReport(IDesignerHost designerHost, XtraReportModel model, object dataSource, string dataMember) {
            return false;
        }
        bool IWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            if (model.DataSourceType == CustomDataSourceType.StaticPersons) {
                dataMember = string.Empty;
                dataSource = CreateObjectDataSource("GetStaticPersons");
                return true;
            }
            else if (model.DataSourceType == CustomDataSourceType.XmlPersons) {
                dataMember = string.Empty;
                dataSource = CreateObjectDataSource("GetXmlPersons");
                return true;
            }
            else {
                dataMember = string.Empty;
                dataSource = null;
                return false;
            }
        }
        static ObjectDataSource CreateObjectDataSource(string dataMember) {
            var objectDataSource = new ObjectDataSource();
            objectDataSource.Constructor = new ObjectConstructorInfo();
            objectDataSource.DataMember = dataMember;
            objectDataSource.DataSource = typeof(PersonsSource);
            objectDataSource.Name = "objectDataSource1";
            return objectDataSource;
        }
    }
    public class CustomDataSourceType : DataSourceType {
        public static readonly DataSourceType StaticPersons = new CustomDataSourceType();
        public static readonly DataSourceType XmlPersons = new CustomDataSourceType();
    }
}
