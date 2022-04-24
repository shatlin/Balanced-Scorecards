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

public partial class Setup_CreateScorecard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblPageInfo.Text =
            "Please press the button to create integrated scorecards.Please make sure that the scorecard exercises are complete before creating the Integrated scorecards";
    }
    protected void btnCreateSC_Click(object sender, EventArgs e)
    {
        CreateScorecardBL objcreatesc=new CreateScorecardBL();
        objcreatesc.createSccorecard();
    }
}
