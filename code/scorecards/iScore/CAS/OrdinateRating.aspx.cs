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
using Business.Setup;

public partial class CAS_OrdinateRating : System.Web.UI.Page
{

    // Note: lblRolename is used to hold the subordinate user id.

    public static bool isPageFirstLoad = true;

    protected void Page_Load(object sender, EventArgs e)
    {
        #region authentication

        if (Session["UserType"] == null || (Convert.ToInt32(UserAutherization.UserType.Administrator) < Convert.ToInt32(Session["UserType"])))
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }

        if (Session["UserId"] == null)
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }
        #endregion


        #region if Page is Postback Remove "SelectOrdinates"
        if (Page.IsPostBack)
        {
            isPageFirstLoad = false;
            
            if(drpSubordinates.Items[0].Value=="0")
                   drpSubordinates.Items.RemoveAt(0);
            
        }
        #endregion

        
        # region get Role Details and User Details of the Ordinate
        OrgRoleBL objOrgRoleBl = new OrgRoleBL();
        DataTable dtRoleDetails = objOrgRoleBl.GetOrgRoleByUserId(Convert.ToInt32((Session["UserId"])));
        
        lblOrdinateId.Text = Convert.ToString(Session["UserId"]);
        lblUserInfo.Text = string.Format("Your Name :{0}&nbsp;&nbsp;&nbsp; Your Role :{1}&nbsp;&nbsp;&nbsp;   ", Session["UserName"], dtRoleDetails.Rows[0][1]);
        
        #endregion

        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageinfoRoleCompetency);
        GridView1.Visible = true;
    }
   
    protected static string GetCompetencyName(object iCompetencyId)
    {
        string sCompetencyName = string.Empty;
        if (iCompetencyId == null)
            return string.Empty;

        try
        {
            CompetencyBL competencyBL = new CompetencyBL();
            sCompetencyName = competencyBL.GetCompetencyNameByID(Convert.ToInt32(iCompetencyId));
        }

        catch
        {

        }
        return sCompetencyName;
    }

    protected static string GetOrgRoleName(object iOrgRoleId)
    {
        string sOrgRoleName = string.Empty;
        if (iOrgRoleId == null)
            return string.Empty;

        try
        {
            OrgRoleBL OrgRoleBL = new OrgRoleBL();
            sOrgRoleName = OrgRoleBL.GetOrgRoleNameByID(Convert.ToInt32(iOrgRoleId));
        }

        catch
        {

        }
        return sOrgRoleName;
    }

    

    protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        if(isPageFirstLoad == true)
        {
            return;
        }
        if(lblRoleName.Text=="0")
        {
            return;
        }

        //1. Dont need to check if user has rated.Its already checked in the drop down list change.
        //2. Check if the user is already rated by the ordinate
        
        ScoreDetailBL objScoreDeialBL = new ScoreDetailBL();

        ScoreMasterBL objScoreMasterBL = new ScoreMasterBL();
        int ScoreMasterId = objScoreMasterBL.CheckifUserExistsinScoreMaster(Convert.ToInt32(drpSubordinates.SelectedItem.Value));
        // check if the employee id exists in the scoremaster. 
        if( ScoreMasterId==0)
        {
            lblResult.Text = "Your Subordinate has not completed his rating. You cannot rate him until he completed his self rating";
            BtnSave.Enabled = false;
            return;
        }

        // user already completed self rating.Check if ordinate already rated the user
        if (objScoreDeialBL.isUserRatedByOrdinate(Convert.ToInt32(drpSubordinates.SelectedItem.Value)))
        {
            ScoreDetailBL objScoreDetailBL = new ScoreDetailBL();
            DataTable DtScoreDetail = objScoreDetailBL.GetScoreDetailsByScoreMasterId(ScoreMasterId);

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lCompetencyId = (Label)e.Row.FindControl("Label7");
                int iCompetencyId = Convert.ToInt32(lCompetencyId.Text);

                foreach (DataRow dr in DtScoreDetail.Rows)
                {
                    int iDataCompetencyId = Convert.ToInt32(dr[2]);
                    if (iDataCompetencyId == iCompetencyId)
                    {
                        Label lSelfRating = new Label();
                        lSelfRating.Text = dr[4].ToString();
                        e.Row.Cells[6].Controls.Add((lSelfRating));
                        e.Row.FindControl("DropDownList3").Visible = false;
                        break;
                    }
                }

                lblResult.Text = "This sub ordinate has already been rated by you.";
                BtnSave.Enabled = false;
                return;
            }


        }
        
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ScoreMasterBL objScoreMaster = new ScoreMasterBL();

        // get the user of the subordinate and then get the masterscoreid.

      //  objScoreMaster.AddScoreMaster(null, Convert.ToInt32(Session["userid"]), null);
        int iAppUserScoreMasterid = objScoreMaster.GetScoreMasterbyAppUsesrId(Convert.ToInt32(drpSubordinates.SelectedItem.Value));
        int iScoreDetailId;
        foreach(GridViewRow gr in GridView1.Rows)
        {
            if (gr.RowType == DataControlRowType.DataRow)
            {
            
                    Label lRoleCompetencyId = (Label) gr.FindControl("Label2");
                    int iRoleCompetencyId = Convert.ToInt32(lRoleCompetencyId.Text);

                    Label lOrgRoleId = (Label) gr.FindControl("Label4");
                    int iOrgRoleId = Convert.ToInt32(lOrgRoleId.Text);

                    Label lCompetencyId = (Label) gr.FindControl("Label7");
                    int iCompetencyId = Convert.ToInt32(lCompetencyId.Text);


                    DropDownList drlist = (DropDownList) gr.FindControl("DropDownList3");
                    int iSelfRating = Convert.ToInt32(drlist.SelectedItem.Value);

                    // Get scoredetail id for the scoremaster and competencyid combination
                    ScoreDetailBL objScoreDetail = new ScoreDetailBL();
                    iScoreDetailId = objScoreDetail.GetScoreDetailIDForCompetencyAndScoreMasterId(iAppUserScoreMasterid, iCompetencyId);

                    objScoreDetail.UpdateScoreDetail(iScoreDetailId, iAppUserScoreMasterid, iCompetencyId, null, iSelfRating, null);
           
            }
        }
        GridView1.DataBind();
        BtnSave.Enabled = false;
        lblResult.Text = "Ordinate Rating completed";
    }

    protected void drpSubordinates_SelectedIndexChanged(object sender, EventArgs e)
    {
        HandleSuboridnateValueChange();
    }

    protected void HandleSuboridnateValueChange()
    {


//get role id for the appuserid
        OrgRoleBL objOrgRoleBL=new OrgRoleBL();
        DataTable dtOrgRole=objOrgRoleBL.GetOrgRoleByUserId(Convert.ToInt32(drpSubordinates.SelectedItem.Value));
        lblRoleName.Text = dtOrgRole.Rows[0][0].ToString();

        ScoreMasterBL objScoreMasterBL = new ScoreMasterBL();
        int ScoreMasterId = objScoreMasterBL.CheckifUserExistsinScoreMaster(Convert.ToInt32(drpSubordinates.SelectedItem.Value));
        if (ScoreMasterId == 0)
        {
            BtnSave.Enabled = false;
            lblResult.Text = "Your Subordinate has not completed his rating. You cannot rate him until he completed his self rating";
            GridView1.Visible = false;
            return;
        }
        // check if the employee id exists in the scoremaster. 
        lblResult.Text = "Your Suboridnate Completed His Self Rating.You can rate him now";
        BtnSave.Enabled = true;
       
    }
}
