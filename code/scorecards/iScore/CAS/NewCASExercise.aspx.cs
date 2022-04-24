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
using Business.CAS;
public partial class CAS_NewCASExercise : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblPageInfo.Text = "All the previous Exercise Data will be lost. Are you sure you want to start a new Exercise?";
    }
    protected void btnStartNewExercise_Click(object sender, EventArgs e)
    {
        ScoreMasterBL objScoreMasterBL = new ScoreMasterBL();
        ScoreDetailBL objScoreDetailBL = new ScoreDetailBL();
        objScoreDetailBL.DeleteAllScoreDetail();
        objScoreMasterBL.DeleteAllScoreMaster();

        lblResult.Text = "A new Exercise is started";
    }
}
