using System.ComponentModel.Composition;
using System.IO;
using DevExpress.Xpf.Printing.Service.Extensions;
using DevExpress.XtraPrinting;

namespace S171806_CustomArgs.Web {
    [Export(typeof(IDocumentExportInterceptor))]
    public class DocumentExportInterceptor : IDocumentExportInterceptor {
        #region IDocumentExportInterceptor Members
        void IDocumentExportInterceptor.InvokeBefore(Document document, ExportOptionsBase exportoptions, object customArgs) {
        }

        void IDocumentExportInterceptor.InvokeAfter(Stream documentContent, ExportOptionsBase exportoptions, object customArgs) {
            var exportState = customArgs as ExportState;
            if(exportState == null) {
                return;
            }
            var fileName = (exportState.FileName ?? "document") + ".pdf";
            using(var file = File.OpenWrite(Path.Combine(StaticInfo.AppDataDirectoryPath, fileName))) {
                documentContent.CopyTo(file);
            }
        }
        #endregion
    }
}