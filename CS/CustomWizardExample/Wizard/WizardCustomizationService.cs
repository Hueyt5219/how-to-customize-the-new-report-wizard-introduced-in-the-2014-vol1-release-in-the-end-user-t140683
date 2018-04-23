using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomWizardExample.Wizard.Presenters;
using CustomWizardExample.Wizard.Views;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.XtraReports.Wizards3;
using DevExpress.DataAccess.Native;
using DevExpress.Data.XtraReports.Wizard.Presenters;

namespace CustomWizardExample.Wizard {
    class WizardCustomizationService : IWizardCustomizationService {
        void IWizardCustomizationService.CustomizeDataSourceWizard(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<DevExpress.DataAccess.Wizard.Model.DataSourceModel> tool) {
            // set the start page
            tool.StartPage = typeof(ChoosePersonsPage2<DataSourceModel>);

            // register the custom page
            tool.RegisterPage<ChoosePersonsPage2<DataSourceModel>, ChoosePersonsPage2<DataSourceModel>>();

            // register the custom page view
            tool.RegisterPageView<IChoosePersonsPageView, ChoosePersonsPageView2>();
        }
        void IWizardCustomizationService.CustomizeReportWizard(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<XtraReportModel> tool) {
            // redefine the start page
            tool.RegisterPage<DevExpress.XtraReports.Wizards3.Presenters.ChooseReportTypePageEx<XtraReportModel>, ChoosePersonsPage>();

            // register the custom page
            tool.RegisterPage<ChoosePersonsPage2<XtraReportModel>, ChoosePersonsPage3>();

            // register the custom page view
            tool.RegisterPageView<IChoosePersonsPageView, ChoosePersonsPageView2>();
        }
        bool IWizardCustomizationService.TryCreateReport(System.ComponentModel.Design.IDesignerHost designerHost, XtraReportModel model, object dataSource, string dataMember) {
            return false;
        }
        bool IWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            if(model.DataSourceType == CustomDataSourceType.StaticPersons) {
                dataMember = string.Empty;
                dataSource = CreateObjectDataSource("GetStaticPersons");
                return true;
            } else if(model.DataSourceType == CustomDataSourceType.XmlPersons) {
                dataMember = string.Empty;
                dataSource = CreateObjectDataSource("GetXmlPersons");
                return true;
            } else {
                dataMember = string.Empty;
                dataSource = null;
                return false;
            }
        }
        static DevExpress.DataAccess.ObjectBinding.ObjectDataSource CreateObjectDataSource(string dataMember) {
            var objectDataSource = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource();
            objectDataSource.Constructor = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
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
