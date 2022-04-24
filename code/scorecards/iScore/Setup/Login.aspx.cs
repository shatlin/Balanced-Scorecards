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


public partial class Setup_Login : System.Web.UI.Page
{
    private bool isFirstTimeUse = false;

    protected void Page_Load(object sender, EventArgs e)
    {

        txtPassword.Focus();
        LoginManager objLoginManager = new LoginManager();
        AppUserBL objAppuser = new AppUserBL();


        // Checking if the sytem is used for the first time
        try
        {
            DataTable AdduserList = objAppuser.GetAppUserDetails();
            if (AdduserList.Rows.Count == 0)
            {
                Response.Redirect(MsgColl.GetMsg(MsgColl.Msg.PageApplicationUser));
            }

        }
        catch (Exception objException)
        {

            DisplayErrorTable(MsgColl.GetMsg(MsgColl.Msg.ErrorOccured));
            return;
        }


        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoLogin);

        btnLogin.Text = MsgColl.GetMsg(MsgColl.Msg.BtnTextLogin);

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        LoginManager objLoginManager = new LoginManager();

        try
        {
            int iAppUserId = objLoginManager.ValidateUser(txtUserId.Text, txtPassword.Text);
            if (iAppUserId>0)
            {
                int iSystemRoleId = objLoginManager.GetSystemRole(iAppUserId);
                Session["UserId"] = iAppUserId;
                Session["UserType"] = iSystemRoleId;
                Session["UserName"] = txtUserId.Text;
                Response.Redirect(MsgColl.GetMsg(MsgColl.Msg.PageHome));
            }
            else
            {
                Label3.Text = "Login Failed.Please try again";
                return;
            }
        }
        catch (Exception ex)
        {
            DisplayErrorTable(MsgColl.GetMsg(MsgColl.Msg.ErrorOccured));
            return;
        }

        // check in the db of the employee & grant him access if valid, else display Msg


    }

    protected void DisplayErrorTable(string sErrorMsg)
    {

        //  tblErrorMsg.Visible = true;
        //  lblErrroMsg.Text = sErrorMsg;
    }

    protected void HideErrorTable()
    {
        //  tblErrorMsg.Visible = false;
        //  lblErrroMsg.Text = string.Empty;
    }
}
