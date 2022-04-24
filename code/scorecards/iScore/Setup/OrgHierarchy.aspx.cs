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

public partial class Setup_OrgHierarchy : System.Web.UI.Page
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
        if (lblPageInfo != null) lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoOrgHierarchy);
    }

    protected string GetLocationName(object iLocationId)
    {
        string sLocationName = string.Empty;
        if (iLocationId == null)
            return string.Empty;
        try
        {
            LocationBL locationBL = new LocationBL();
            sLocationName = locationBL.GetLocationNameByID(Convert.ToInt32(iLocationId));
        }
        catch
        {
            
        }
        return sLocationName;
    }

    protected string GetParentOrganizationName(object iParentId)
    {
        string sParentName = string.Empty;
        if (iParentId == null)
            return string.Empty;

        try
        {
            OrgHierarchyBL orgHierarchyBL = new OrgHierarchyBL();
            sParentName = orgHierarchyBL.GetOrganizationNameByID(Convert.ToInt32(iParentId));
        }
        
        catch
        {

        }
        return sParentName;
    }

    
    


    protected void grdOrgHierarchy_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            OrgHierarchyData.Insert();
        }

    }
    protected void OrgHierarchyData_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {


        TextBox NewOrgName = (TextBox)grdOrgHierarchy.FooterRow.FindControl("txtOrgHierarchyName");
        DropDownList NewLocation = (DropDownList)grdOrgHierarchy.FooterRow.FindControl("drpFooterLocation");
        DropDownList NewParent = (DropDownList)grdOrgHierarchy.FooterRow.FindControl("drpParentOrg");



        e.InputParameters["OrgHierarchyName"] = NewOrgName.Text;
        e.InputParameters["LocationId"] = NewLocation.SelectedItem.Value;
        e.InputParameters["ParentOrgHierarchyId"] = NewParent.SelectedItem.Value;
        e.InputParameters["OrgHierarchySequence"] = null;

        
        

    }
}
