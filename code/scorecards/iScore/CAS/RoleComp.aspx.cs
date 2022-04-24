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

public partial class CAS_RoleComp : System.Web.UI.Page
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

    protected void ObjectDataSource2_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {

        DropDownList NewOrgRole = (DropDownList)GridView1.FooterRow.FindControl("drpFooterOrgRole");
        DropDownList NewCompetency = (DropDownList)GridView1.FooterRow.FindControl("drpFooterCompetency");
        DropDownList NewDesiredRating = (DropDownList)GridView1.FooterRow.FindControl("drpFooterDesiredRating");


        e.InputParameters["OrgRoleId"] = NewOrgRole.SelectedItem.Value;
        e.InputParameters["CompetencyId"] = NewCompetency.SelectedItem.Value;
        e.InputParameters["DesiredRating"] = NewDesiredRating.SelectedItem.Value;
        e.InputParameters["RatingMasterId"] = 1; //hardcoded.Not used
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            ObjectDataSource2.Insert();
        }
    }
}
