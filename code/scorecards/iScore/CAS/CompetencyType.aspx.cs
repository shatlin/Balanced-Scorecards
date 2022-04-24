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

public partial class CAS_CompetencyType : System.Web.UI.Page
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
        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoCompetencyType);
    }

    protected void grdCompetencyTypes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            CompetencyTypeData.Insert();
        }
    }
    protected void CompetencyTypeData_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {
        TextBox NewCompetencyTypeName = (TextBox)grdCompetencyTypes.FooterRow.FindControl("txtCompetencyTypeName");
        TextBox NewCompetencyTypeDescription = (TextBox)grdCompetencyTypes.FooterRow.FindControl("txtCompetencyTypeDescription");
        e.InputParameters["CompetencyTypeName"] = NewCompetencyTypeName.Text;
        e.InputParameters["CompetencyTypeDescription"] = NewCompetencyTypeDescription.Text;
    }
}
