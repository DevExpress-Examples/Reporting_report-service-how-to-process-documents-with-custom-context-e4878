Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraPrinting

Namespace S171806_CustomArgs
	Public Class CustomReportPreviewModel
		Inherits ReportPreviewModel
		Public Sub SaveDocumentOnServer()
			MyBase.Export(ExportFormat.Pdf, New ExportState With {.FileName = "TestDocument"})
		End Sub
	End Class
End Namespace
