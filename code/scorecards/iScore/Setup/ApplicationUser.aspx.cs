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

public partial class Setup_ApplicationUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        #region authentication

        if (Session["UserType"]==null ||(Convert.ToInt32(UserAutherization.UserType.Administrator) < Convert.ToInt32(Session["UserType"])))
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }
        #endregion

        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoApplicationUser);
        ShowHideAddUserTable();
    }

    public void CheckAuthorization(int iUserType)
    {
        try
        {
            if(iUserType < Convert.ToInt32(Session["UserType"]))
            {
                Server.Transfer("~/AccessDenied.aspx");
            }
        }
        catch
        {
            Server.Transfer("~/AccessDenied.aspx");
        }


    }

    protected string GetSystemRoleName(object iSystemRoleId)
    {
        string sSystemRoleName = string.Empty;
        if (iSystemRoleId == null)
            return string.Empty;
        try
        {
            SystemRoleBL systemRoleBL = new SystemRoleBL();
            sSystemRoleName = systemRoleBL.GetSystemRoleNameByID(Convert.ToInt32(iSystemRoleId));
        }
        catch
        {

        }
        return sSystemRoleName;
    }

 

    protected string GetAppUserName(object iAppUserId)
    {
        string sAppUserName = string.Empty;
        if (iAppUserId == null)
            return string.Empty;
        try
        {
            AppUserBL appUserBL = new AppUserBL();
            sAppUserName = appUserBL.GetAppUserbyID(Convert.ToInt32(iAppUserId));
        }
        catch
        {

        }
        return sAppUserName;
    }


    //protected string GetLocationName(object iLocationId)
    //{
    //    string sLocationName = string.Empty;
    //    if (iLocationId == null)
    //        return string.Empty;
    //    try
    //    {
    //        LocationBL locationBL = new LocationBL();
    //        sLocationName = locationBL.GetLocationNameByID(Convert.ToInt32(iLocationId));
    //    }
    //    catch
    //    {

    //    }
    //    return sLocationName;
    //}

    protected string GetOrganizationName(object iOrgId)
    {
       
        string sOrgName = string.Empty;
        if (iOrgId == null)
            return string.Empty;

        try
        {
            OrgHierarchyBL orgHierarchyBL = new OrgHierarchyBL();
            sOrgName = orgHierarchyBL.GetOrganizationNameByID(Convert.ToInt32(iOrgId));
        }

        catch
        {

        }
        return sOrgName;
    }

    


    protected string GetOrgRoleName(object iOrgRoleId)
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


  

    
    


   
    protected void GrdAppUsers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       if (e.CommandName == "Insert" && Page.IsValid)
       {
           AppUserDataSource.Insert();
       }

       ShowHideAddUserTable();

    }

    protected void AppUserDataSource_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {

        if (GrdAppUsers.Rows.Count != 0)
        {
            TextBox txtAppUserOrgId = (TextBox)GrdAppUsers.FooterRow.FindControl("txtAppUserOrgId");
            TextBox txtAppUserName = (TextBox)GrdAppUsers.FooterRow.FindControl("txtAppUserName");
            TextBox txtAppUserEmail = (TextBox)GrdAppUsers.FooterRow.FindControl("txtAppUserEmail");
            DropDownList DrpSystemRoldId = (DropDownList)GrdAppUsers.FooterRow.FindControl("DrpSystemRoldId");
            DropDownList DrpOrgHierarchyId = (DropDownList)GrdAppUsers.FooterRow.FindControl("DrpOrgHierarchyId");
            DropDownList DrpOrgRoleId = (DropDownList)GrdAppUsers.FooterRow.FindControl("DrpOrgRoleId");
            DropDownList DrpOrdinateAppUserId = (DropDownList)GrdAppUsers.FooterRow.FindControl("DrpOrdinateAppUserId");
            TextBox txtJoinDate = (TextBox)GrdAppUsers.FooterRow.FindControl("txtJoinDate");
            CheckBox chkIsActive = (CheckBox)GrdAppUsers.FooterRow.FindControl("chkIsActive");

            e.InputParameters["AppUserOrgId"] = txtAppUserOrgId.Text;
            e.InputParameters["AppUserName"] = txtAppUserName.Text;
            e.InputParameters["AppUserEmail"] = txtAppUserEmail.Text;
            e.InputParameters["SystemRoldId"] = DrpSystemRoldId.SelectedItem.Value;
            e.InputParameters["OrgHierarchyId"] = DrpOrgHierarchyId.SelectedItem.Value;
            e.InputParameters["OrgRoleId"] = DrpOrgRoleId.SelectedItem.Value;
            if (Convert.ToInt32(DrpOrdinateAppUserId.SelectedItem.Value) == 0)
            {
                e.InputParameters["OrdinateAppUserId"] = null;
            }
            else
            {
                e.InputParameters["OrdinateAppUserId"] = DrpOrdinateAppUserId.SelectedItem.Value;
            }
            e.InputParameters["JoinDate"] = txtJoinDate.Text;
            e.InputParameters["IsActive"] = chkIsActive.Checked;
        }
        else
        {
           
            e.InputParameters["AppUserOrgId"] = EmptytxtAppUserOrgId.Text;
            e.InputParameters["AppUserName"] = EmptytxtAppUserName.Text;
            e.InputParameters["AppUserEmail"] = EmptytxtAppUserEmail.Text;
            e.InputParameters["SystemRoldId"] = EmptyDrpSystemRoldId.SelectedItem.Value;
            e.InputParameters["OrgHierarchyId"] = EmptyDrpOrgHierarchyId.SelectedItem.Value;
            e.InputParameters["OrgRoleId"] = EmptyDrpOrgRoleId.SelectedItem.Value;

            e.InputParameters["OrdinateAppUserId"] = null;
            
            e.InputParameters["JoinDate"] = EmptytxtJoinDate.Text;
            e.InputParameters["IsActive"] = EmptychkIsActive.Checked;

        }

       
        
    }

    protected void EmptybtnAddAppUser_Click(object sender, EventArgs e)
    {
        AppUserDataSource.Insert();

         ShowHideAddUserTable();
         Response.Redirect(MsgColl.GetMsg(MsgColl.Msg.PageLogin));

        
    }

    protected void ShowHideAddUserTable()
    {
        AppUserBL appUserBL = new AppUserBL();
        DataTable dtAppuser = appUserBL.GetAppUserDetails();


        //EmptytxtAppUserOrgId.Text="";
        //EmptytxtAppUserName.Text = "";
        //EmptytxtAppUserEmail.Text="";
        //EmptytxtJoinDate.Text="";
        //EmptychkIsActive.Checked=false;

        if (dtAppuser.Rows.Count == 0)
        {
            PnlAddRow.Visible = true;
        }
        else
        {
            PnlAddRow.Visible = false;
        }
    }
    protected void GrdAppUsers_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        ShowHideAddUserTable();
    }
}
