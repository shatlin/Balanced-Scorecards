using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Business.Setup;


public partial class Setup_AccessDenied : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoLogin);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/setup/login.aspx");
    }
}
  
