Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing

Namespace S171806_CustomArgs.Web
	Public Class [Global]
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			ServiceKnownTypeProvider.Register(Of ExportState)()
			StaticInfo.AppDataDirectoryPath = Server.MapPath("~/App_Data/")
		End Sub

		Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
	End Class
End Namespace