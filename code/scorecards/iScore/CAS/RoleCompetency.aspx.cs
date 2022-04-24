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
using Business.CAS;
public partial class CAS_RoleCompetency : System.Web.UI.Page
{
    //static int iSelectedRole = 0;
    //static int iSelectedCompetency = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        //EnableDisableButton2();

        //EnableDisableButton1();

        //if (!IsPostBack)
        //{

        //    AddRolestoTree();
        //    AddCompetenciestoTree();

        //}


    }

    //protected void EnableDisableButton1()
    //{
    //    try
    //    {
    //        if (TreeView2.SelectedNode != null & TreeView1.SelectedNode.Depth == 0)
    //        {
    //            Button1.Enabled = true;
    //        }
    //        else
    //        {
    //            Button1.Enabled = false;
    //        }
    //    }
    //    catch
    //    {

    //    }
    //}

    //protected void EnableDisableButton2()
    //{
    //    if (TreeView1.SelectedNode != null && (TreeView1.SelectedNode.Depth > 0))

    //        Button2.Enabled = true;


    //    else

    //        Button2.Enabled = false;

    //}

    //protected void AddRolestoTree()
    //{
    //    OrgRoleBL orgRoleBL = new OrgRoleBL();
    //    RoleCompetencyBL objRoleCompetencyBL = new RoleCompetencyBL();

    //    DataTable OrgRoleTable = orgRoleBL.GetOrgRoles();
    //    DataTable CompetenciesForRole = new DataTable();

    //    foreach (DataRow dr in OrgRoleTable.Rows)
    //    {
    //        TreeNode root = new TreeNode();
    //        root.Text = Convert.ToString(dr[1]);
    //        root.Target = "_blank";
    //        root.Value = Convert.ToString(dr[0]);


    //        CompetenciesForRole = objRoleCompetencyBL.GetCompetenciesForRole(Convert.ToInt32(dr[0]));

    //        if (CompetenciesForRole.Rows.Count > 0)
    //        {
    //            foreach (DataRow dr2 in CompetenciesForRole.Rows)
    //            {
    //                TreeNode child = new TreeNode();
    //                child.Text = Convert.ToString(dr2[0]);
    //                child.Value = Convert.ToString(dr2[3]);
    //                child.Target = "_blank";
    //                root.ChildNodes.Add(child);
    //            }
    //        }
    //        TreeView1.Nodes.Add(root);


    //    }
    //}

    //protected void AddCompetenciestoTree()
    //{
    //    CompetencyTypeBL competencyTypeBL = new CompetencyTypeBL();
    //    CompetencyBL competencyBL = new CompetencyBL();
    //    DataTable CompetencyTypeTable = competencyTypeBL.GetCompetencyTypes();
    //    DataTable CompetencyTable = new DataTable();

    //    foreach (DataRow dr in CompetencyTypeTable.Rows)
    //    {
    //        TreeNode root = new TreeNode();
    //        root.Text = Convert.ToString(dr[1]);
    //        root.SelectAction = TreeNodeSelectAction.None;


    //        CompetencyTable = competencyBL.GetCompetenciesByType(Convert.ToInt32(dr[0]));

    //        foreach (DataRow dr2 in CompetencyTable.Rows)
    //        {
    //            TreeNode child = new TreeNode();
    //            child.Text = Convert.ToString(dr2[2]);
    //            child.Value = Convert.ToString(dr2[0]);
    //            child.Target = "_blank";
    //            root.ChildNodes.Add(child);
    //        }

    //        TreeView2.Nodes.Add(root);
    //    }

    //}



    //protected void TreeView2_SelectedNodeChanged(object sender, EventArgs e)
    //{
    //    iSelectedCompetency = Convert.ToInt32(TreeView2.SelectedNode.Value);

    //}
    //protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    //{
    //    iSelectedRole = Convert.ToInt32(TreeView1.SelectedNode.Value);

    //}
    //protected void Button1_Click(object sender, EventArgs e)
    //{

    //}
}
