using System;

public partial class common_iMaster : System.Web.UI.MasterPage
{
    public int iUserType;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserType"] != null)
        {
            LinkButton1.Visible = true;
        }
        iUserType = Convert.ToInt32(Session["UserType"]);

        if (iUserType == 1)
        {
            SuperUserMenu.Visible = true;
            AdminMenu.Visible = false;
            Appusermenu.Visible = false;
            return;
        }
        if (iUserType == 2)
        {
            SuperUserMenu.Visible = false;
            AdminMenu.Visible = true;
            Appusermenu.Visible = false;
            return;
        }
        if (iUserType == 3)
        {
            SuperUserMenu.Visible = false;
            AdminMenu.Visible = false;
            Appusermenu.Visible = true;
            
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/setup/login.aspx");
    }
}
