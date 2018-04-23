Imports System.ComponentModel.Composition
Imports System.IO
Imports DevExpress.Xpf.Printing.Service.Extensions
Imports DevExpress.XtraPrinting
Imports Microsoft.VisualBasic

Namespace S171806_CustomArgs.Web
    <Export(GetType(IDocumentExportInterceptor))> _
    Public Class DocumentExportInterceptor
        Implements IDocumentExportInterceptor
#Region "IDocumentExportInterceptor Members"
        Sub InvokeBefore(ByVal document As Document, ByVal exportoptions As ExportOptionsBase, ByVal customArgs As Object) Implements IDocumentExportInterceptor.InvokeBefore
        End Sub

        Sub InvokeAfter(ByVal documentContent As Stream, ByVal exportoptions As ExportOptionsBase, ByVal customArgs As Object) Implements IDocumentExportInterceptor.InvokeAfter
            Dim exportState = TryCast(customArgs, ExportState)
            If exportState Is Nothing Then
                Return
            End If
            Dim fileName = (If(exportState.FileName, "document")) & ".pdf"
            Using file = System.IO.File.OpenWrite(Path.Combine(StaticInfo.AppDataDirectoryPath, fileName))
                documentContent.CopyTo(file)
            End Using
        End Sub
#End Region
    End Class
End Namespace