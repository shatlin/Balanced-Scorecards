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

public partial class Setup_GlobalParameters : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        #region authentication

        if (Session["UserType"] == null || (Convert.ToInt32(UserAutherization.UserType.SuperUser) < Convert.ToInt32(Session["UserType"])))
        {
            Server.Transfer("~/AccessDenied.aspx");
            return;
        }
        #endregion

        GlobalParameter objGlobParameter = new GlobalParameter();
        lblPageInfo.Text = MsgColl.GetMsg(MsgColl.Msg.PageInfoGlobalParameters);

        try
        {
            grdVwGlobalParemeter.DataSource = objGlobParameter.GetGlobalParameters();
            grdVwGlobalParemeter.DataBind();
        }
        catch (Exception objException)
        {

        //    DisplayErrorTable(MsgColl.GetMsg(MsgColl.Msg.ErrorOccured));
            return;
        }

    }



    protected void grdVwGlobalParemeter_SelectedIndexChanged(object sender, EventArgs e)
    {
        GlobalParameter objGlobParameter = new GlobalParameter();

        try
        {

            GridViewRow row = grdVwGlobalParemeter.SelectedRow;
            int GlobalParameterId = Convert.ToInt32(grdVwGlobalParemeter.DataKeys[row.RowIndex].Value);
            grdVwGlobalParemeterDetails.DataSource = objGlobParameter.GetGlobalParameterDetails(GlobalParameterId);
            grdVwGlobalParemeterDetails.DataBind();
        }
        catch (Exception objException)
        {

          //  DisplayErrorTable(MsgColl.GetMsg(MsgColl.Msg.ErrorOccured));
            return;
        }
    }

    protected void grdVwGlobalParemeterDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
        GlobalParameter objGlobParameter = new GlobalParameter();

        try
        {
            GridViewRow row = grdVwGlobalParemeterDetails.SelectedRow;
            int GlobalParameterDetailId = Convert.ToInt32(grdVwGlobalParemeterDetails.DataKeys[row.RowIndex].Value);

            objGlobParameter.UpdateGlobalParameter(GlobalParameterDetailId);

            row = grdVwGlobalParemeter.SelectedRow;
            int GlobalParameterId = Convert.ToInt32(grdVwGlobalParemeter.DataKeys[row.RowIndex].Value);
            grdVwGlobalParemeterDetails.DataSource = objGlobParameter.GetGlobalParameterDetails(GlobalParameterId);
            grdVwGlobalParemeterDetails.DataBind();
        }
        catch (Exception objException)
        {

            //DisplayErrorTable(MsgColl.GetMsg(MsgColl.Msg.ErrorOccured));
            return;
        }

    }


}
