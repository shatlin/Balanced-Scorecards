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

public partial class Setup_ViewIS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblPageInfo.Text =
            "This is the page to display the integrated scorecard. If you cannot view a scorecard it is not configured";
    }
}
