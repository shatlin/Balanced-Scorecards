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

public partial class Setup_OrgRole : System.Web.UI.Page
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
        if (lblPageInfo != null) lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoOrganizationRole);
    }
    protected void grdOrgRole_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            OrgRoleData.Insert();
        }
    }
    protected void OrgRoleData_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {
        TextBox NewOrgRoleName =(TextBox)grdOrgRole.FooterRow.FindControl("txtOrgRoleName");
        TextBox NewRoleDescription = (TextBox)grdOrgRole.FooterRow.FindControl("txtRoleDescription");
        e.InputParameters["OrgRoleName"] = NewOrgRoleName.Text;
        e.InputParameters["OrgRoleDetail"] = NewRoleDescription.Text;

        }

}
