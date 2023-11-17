using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class SessionSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Application["usercount"]);
                Response.Write("<br/>");
            Response.Write("Printing without Session variable" + Session.SessionID);
            Response.Write("<br/>");
            Response.Write("Session ID=" + Session["mysession"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Send anything through a session variable
            Session["empid"] = 12;
            Session["ename"] = "Sumit";
            Response.Redirect("~/SessionReceiver.aspx");

        }
    }
}