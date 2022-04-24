using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data.Setup.OrgRoleTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
   public class OrgRoleBL
    {
       private OrgRoleTableAdapter orgRoleAdapter = new OrgRoleTableAdapter();

       protected OrgRoleTableAdapter OrgRoleAdapter
        {
            get
            {
                if (orgRoleAdapter == null)
                {
                    orgRoleAdapter = new OrgRoleTableAdapter();
                }

                return orgRoleAdapter;
            }

        }

        
        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
       public Data.Setup.OrgRole.OrgRoleDataTable GetOrgRoles()
        {
            return OrgRoleAdapter.GetOrgRoleDetails();
        }

       [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
       public string GetOrgRoleNameByID(int iOrgRoleId)
       {
           return OrgRoleAdapter.GetOrgRoleNameById((iOrgRoleId)).ToString();

       }



       [System.ComponentModel.DataObjectMethodAttribute
      (System.ComponentModel.DataObjectMethodType.Select, true)]
       public DataTable GetOrgRoleByUserId(int iUserId)
       {
           return OrgRoleAdapter.GetRoleByUserID(iUserId);

       }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
       public bool AddOrgRole(string OrgRoleName, string OrgRoleDetail)
        {

            Data.Setup.OrgRole.OrgRoleDataTable objOrgRole = new Data.Setup.OrgRole.OrgRoleDataTable();
            Data.Setup.OrgRole.OrgRoleRow objOrgRoleRow = objOrgRole.NewOrgRoleRow();

            objOrgRoleRow.OrgRoleName = OrgRoleName;
            if (OrgRoleDetail == string.Empty) objOrgRoleRow.SetOrgRoleDetailNull();
            else objOrgRoleRow.OrgRoleDetail = OrgRoleDetail;
            objOrgRole.AddOrgRoleRow(objOrgRoleRow);


            int rowsAffected = OrgRoleAdapter.Update(objOrgRoleRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
       public bool UpdateOrgRole(int OrgRoleId, string OrgRoleName, string OrgRoleDetail)
        {

            Data.Setup.OrgRole.OrgRoleDataTable objOrgRole = OrgRoleAdapter.GetOrgRoleById(OrgRoleId);

            if (objOrgRole.Count == 0)
                // no matching record found, return false
                return false;
            Data.Setup.OrgRole.OrgRoleRow objOrgRoleRow = objOrgRole[0];

            objOrgRoleRow.OrgRoleName = OrgRoleName;

            if (OrgRoleDetail == string.Empty) objOrgRoleRow.SetOrgRoleDetailNull();

            else objOrgRoleRow.OrgRoleDetail = OrgRoleDetail;

            int rowsAffected = OrgRoleAdapter.Update(objOrgRoleRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteOrgRole(int OrgRoleId)
        {
            int rowsAffected = OrgRoleAdapter.Delete(OrgRoleId);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }


    }


   
}
