using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;

namespace S171806_CustomArgs {
    public class CustomReportPreviewModel : ReportPreviewModel {
        public void SaveDocumentOnServer() {
            base.Export(ExportFormat.Pdf, new ExportState { FileName = "TestDocument" });
        }
    }
}
