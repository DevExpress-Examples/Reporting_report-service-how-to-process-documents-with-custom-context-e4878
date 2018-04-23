using System;
using DevExpress.Xpf.Printing;

namespace S171806_CustomArgs.Web {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            ServiceKnownTypeProvider.Register<ExportState>();
            StaticInfo.AppDataDirectoryPath = Server.MapPath("~/App_Data/");
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}