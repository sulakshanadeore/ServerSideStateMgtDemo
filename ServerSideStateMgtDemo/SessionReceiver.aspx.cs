using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class SessionReceiver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Session.IsNewSession)
            {
                Response.Write(Application["usercount"]);
                Response.Write("<br/>");
                Response.Write("Printing without Session variable" + Session.SessionID);
                Response.Write("<br/>");
                Response.Write("Session ID=" + Session["mysession"]);
                Response.Write("<br/>");
                Response.Write(Session["empid"].ToString());
                Response.Write(Session["ename"].ToString());
            }
            else
            {
                Response.Write("New Session!!");
            }
        }
    }
}
