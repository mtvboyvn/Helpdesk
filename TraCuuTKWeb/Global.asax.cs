using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace t
{
    public class Global : System.Web.HttpApplication
    {

        public static dsSCHICUC dsCHICUC = new dsSCHICUC();
        protected void Application_Start(object sender, EventArgs e)
        {
           string strCHICUCPath = Path.Combine( System.IO.Path.GetFullPath(Server.MapPath("~/App_Data")),"SCHICUC.xml");
           dsCHICUC.ReadXml(strCHICUCPath);
          
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Timeout = 60;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
           
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
           
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}