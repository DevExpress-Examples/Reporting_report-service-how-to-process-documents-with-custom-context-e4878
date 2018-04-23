Imports Microsoft.VisualBasic
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands

Namespace S171806_CustomArgs
	Public Class MainPageViewModel
		Private privateReportPreviewModel As CustomReportPreviewModel
		Public Property ReportPreviewModel() As CustomReportPreviewModel
			Get
				Return privateReportPreviewModel
			End Get
			Private Set(ByVal value As CustomReportPreviewModel)
				privateReportPreviewModel = value
			End Set
		End Property
		Private privateSaveDocumentOnServerCommand As ICommand
		Public Property SaveDocumentOnServerCommand() As ICommand
			Get
				Return privateSaveDocumentOnServerCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateSaveDocumentOnServerCommand = value
			End Set
		End Property

		Public Sub New()
			ReportPreviewModel = New CustomReportPreviewModel With {.ServiceUri = "../ReportService1.svc", .ReportName = "S171806_CustomArgs.Web.XtraReport1, S171806_CustomArgs.Web"}
            SaveDocumentOnServerCommand = New DelegateCommand(Of Object)(Sub(x) ReportPreviewModel.SaveDocumentOnServer())
		End Sub
	End Class
End Namespace
