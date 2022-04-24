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

public partial class CAS_SelfRating : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region authentication

        if (Session["UserType"] == null || (Convert.ToInt32(UserAutherization.UserType.Administrator) < Convert.ToInt32(Session["UserType"])))
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }
        #endregion

        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageinfoRoleCompetency);
        
        
        

        if (Session["UserId"] == null)
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }

        OrgRoleBL objOrgRoleBl=new OrgRoleBL();
        DataTable dtRoleDetails=objOrgRoleBl.GetOrgRoleByUserId(Convert.ToInt32((Session["UserId"])));


        lblRoleName.Text = Convert.ToString(dtRoleDetails.Rows[0][0]);
        lblUserInfo.Text = string.Format("User :{0}&nbsp;&nbsp;&nbsp; Role :{1}&nbsp;&nbsp;&nbsp;   ", Session["UserName"], dtRoleDetails.Rows[0][1]);
        
     

    }

    public void test(object sender,ImageClickEventArgs e)
    {
        lblPageInfo.Text="trial test";
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
        try
        {
            ScoreMasterBL objScoreMasterBL = new ScoreMasterBL();
            int ScoreMasterId = objScoreMasterBL.CheckifUserExistsinScoreMaster(Convert.ToInt32(Session["UserId"]));
            // check if the employee id exists in the scoremaster. 
            lblResult.Text = "Self Rating not completed";

            if (ScoreMasterId > 0)
            {
                BtnSave.Enabled = false;
                lblResult.Text = "Self Rating completed";

                

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
                            lSelfRating.Text = dr[3].ToString();
                            e.Row.Cells[6].Controls.Add((lSelfRating));
                            e.Row.FindControl("DropDownList3").Visible = false;
                            break;
                        }
                    }

                    //DropDownList drlist = (DropDownList)e.Row.FindControl("DropDownList3");
                    ////   e.Row.Cells[3].Text = drlist.SelectedItem.Text;
                    ////e.Row.Cells[4].Text = drlist.SelectedItem.Text;

                    //l1.Text = drlist.SelectedItem.Text;
                    //e.Row.Cells[4].Controls.Add((l1));
                    //e.Row.FindControl("DropDownList3").Visible = false;
                }
            }
            // check if the employee id exists in the scoremaster. If yes,
            //{

            // Get the scoremasterId if that is the case. 
            //with the scoremaster id, get the competency id and self rating datatable.
            // match each competency id with the self rating and fill the self rating as a later in the self rating column
            //disable save button and change the dropdown to label, with values from scoredetail.
            //}

            //if not, do nothing

            // should have a page to clear the ratings and start afresh. It just purges the table.
        }
        catch
        {

        }
        
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ScoreMasterBL objScoreMaster = new ScoreMasterBL();
        objScoreMaster.AddScoreMaster(null, Convert.ToInt32(Session["userid"]), null);
        int latestScoreMasterid = objScoreMaster.GetLatestScoreMasterId();

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

                    ScoreDetailBL objScoreDetail = new ScoreDetailBL();
                    objScoreDetail.AddScoreDetail(latestScoreMasterid, iCompetencyId, iSelfRating, null, null);
           
            }
        }
        GridView1.DataBind();
        BtnSave.Enabled = false;
        lblResult.Text = "Self Rating completed";
    }
    
}
