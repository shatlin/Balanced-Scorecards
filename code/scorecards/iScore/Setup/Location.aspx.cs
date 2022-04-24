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

public partial class Setup_Location : System.Web.UI.Page
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
        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoGlobalParameters);
    }
    protected void grdLocation_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            LocationData.Insert();
        }
    }
    protected void LocationData_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {
        TextBox NewLocationName =(TextBox)grdLocation.FooterRow.FindControl("txtLocationName");
        TextBox NewLocationAddress =(TextBox)grdLocation.FooterRow.FindControl("txtLocationAddress");
        e.InputParameters["LocationName"] = NewLocationName.Text;
        e.InputParameters["LocationAddress"] = NewLocationAddress.Text;

    }

}
