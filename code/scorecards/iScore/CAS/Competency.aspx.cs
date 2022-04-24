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

public partial class CAS_Competency : System.Web.UI.Page
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
    }
    protected void grdCompetency_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Insert" && Page.IsValid)
        {
            CompetencyData.Insert();
        }
    }

    protected static string GetCompetencyTypeName(object iCompetencyTypeId)
    {
        string sCompetencyName = string.Empty;
        if (iCompetencyTypeId == null)
            return string.Empty;

        try
        {
            CompetencyTypeBL competencyBL = new CompetencyTypeBL();
            sCompetencyName = competencyBL.GetCompetencyTypeNameByID(Convert.ToInt32(iCompetencyTypeId));
        }

        catch
        {

        }
        return sCompetencyName;
    }

    protected void CompetencyData_Inserting(object sender, ObjectDataSourceMethodEventArgs e)
    {
       
        DropDownList NewCompetencyTypeid = (DropDownList)grdCompetency.FooterRow.FindControl("DropDownList1");
        TextBox NewCompetencyName = (TextBox)grdCompetency.FooterRow.FindControl("txtCompetencyName");
        TextBox NewCompetencyDesc = (TextBox)grdCompetency.FooterRow.FindControl("txtCompetencyDesc");
        e.InputParameters["CompetencyTypeId"] = NewCompetencyTypeid.SelectedItem.Value;
        e.InputParameters["CompetencyName"] = NewCompetencyName.Text;
        e.InputParameters["CompetencyDesc"] = NewCompetencyDesc.Text;

    }

    
}
