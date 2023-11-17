using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ServerSideStateMgtDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["usercount"] = 0;
        }

        void Session_Start(object sender,EventArgs eventArgs) {
            Session["mysession"]=Session.SessionID;
            int cnt = Convert.ToInt32(Application["usercount"]);
                cnt = cnt + 1;
            Application["usercount"] = cnt;
        }

        void Session_End(object sender,EventArgs eventArgs) { 
        
        
        }


    }
}