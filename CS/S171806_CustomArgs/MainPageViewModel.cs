using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;

namespace S171806_CustomArgs {
    public class MainPageViewModel {
        public CustomReportPreviewModel ReportPreviewModel { get; private set; }
        public ICommand SaveDocumentOnServerCommand { get; private set; }

        public MainPageViewModel() {
            ReportPreviewModel = new CustomReportPreviewModel {
                ServiceUri = "../ReportService1.svc",
                ReportName = "S171806_CustomArgs.Web.XtraReport1, S171806_CustomArgs.Web"
            };
            SaveDocumentOnServerCommand = new DelegateCommand<object>(
                _ => ReportPreviewModel.SaveDocumentOnServer());
        }
    }
}
