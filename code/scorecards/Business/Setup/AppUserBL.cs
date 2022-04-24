using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup.AppUserTableAdapters;
using Data.Setup;


namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class AppUserBL
    {
        private AppUserTableAdapter aUAdapter = new AppUserTableAdapter();

        protected AppUserTableAdapter AppUserAdapter
         {
             get
             {
                 if (aUAdapter == null)
                 {
                     aUAdapter = new AppUserTableAdapter();
                 }

                 return aUAdapter;
             }

         }


        [System.ComponentModel.DataObjectMethodAttribute
            (System.ComponentModel.DataObjectMethodType.Select, true)]
        public AppUser.AppUserDataTable GetSubordinates(int iOrdinateAppUserId)
        {
            return AppUserAdapter.GetSubordinates(iOrdinateAppUserId);

        }

       [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public AppUser.AppUserDataTable GetAppUserDetails()
        {
            return AppUserAdapter.GetAppUserDetails();
        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public string GetAppUserbyID(int iUsedId)
        {
            return AppUserAdapter.GetAppUserNameById((iUsedId)).ToString();


        }



        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddAppUser(string AppUserOrgId, string AppUserName, string AppUserEmail, int SystemRoldId, 
                                int OrgHierarchyId, int OrgRoleId, int OrdinateAppUserId,
                                System.DateTime JoinDate, bool IsActive)
        {
            int rowsAffected = 0;
            AppUser.AppUserDataTable objAppUserTable = new AppUser.AppUserDataTable();

            AppUser.AppUserRow objAURow = objAppUserTable.NewAppUserRow();

            

            try
            {
                objAURow.AppUserOrgId = AppUserOrgId;
                objAURow.AppUserName = AppUserName;
                objAURow.AppUserEmail = AppUserEmail;
                objAURow.SystemRoldId = SystemRoldId;
                objAURow.OrgHierarchyId = OrgHierarchyId;
                objAURow.OrgRoleId = OrgRoleId;

                if (OrdinateAppUserId == 0)
                {

                    objAURow.SetOrdinateAppUserIdNull();
                }
                else
                {
                    objAURow.OrdinateAppUserId = OrdinateAppUserId;
                }
                objAURow.SystemRoldId = SystemRoldId;
                objAURow.OrgRoleId = OrgRoleId;
                objAURow.OrdinateAppUserId = OrdinateAppUserId;
                objAURow.JoinDate = JoinDate;
                objAURow.IsActive = IsActive;

                objAppUserTable.AddAppUserRow(objAURow);

                rowsAffected = AppUserAdapter.Update(objAppUserTable);

            }
            catch (Exception ex)
            {
                return false;
            }
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }



        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateAppUser(int AppUserId,string AppUserOrgId, string AppUserName, string AppUserEmail, int SystemRoldId,
                                int OrgHierarchyId, int OrgRoleId, int OrdinateAppUserId,
                                System.DateTime JoinDate, bool IsActive)
        {

            AppUser.AppUserDataTable objAppUserTable = AppUserAdapter.GetAppUserById(AppUserId);


            if (objAppUserTable.Count == 0)
                // no matching record found, return false
                return false;

            AppUser.AppUserRow objAURow = objAppUserTable[0];

            objAURow.AppUserOrgId = AppUserOrgId;
            objAURow.AppUserName = AppUserName;
            objAURow.AppUserEmail = AppUserEmail;
            objAURow.SystemRoldId = SystemRoldId;
            objAURow.OrgHierarchyId = OrgHierarchyId;
            objAURow.OrgRoleId = OrgRoleId;
            objAURow.OrdinateAppUserId = OrdinateAppUserId;
            objAURow.SystemRoldId = SystemRoldId;
            objAURow.OrgRoleId = OrgRoleId;
            objAURow.OrdinateAppUserId = OrdinateAppUserId;
            objAURow.JoinDate = JoinDate;
            objAURow.IsActive = IsActive;



            int rowsAffected = AppUserAdapter.Update(objAURow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteAppuser(int AppUserId)
        {
            int rowsAffected = AppUserAdapter.Delete(AppUserId);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }

      

    }
}
