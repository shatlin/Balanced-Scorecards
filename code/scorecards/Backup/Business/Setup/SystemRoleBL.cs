using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;
using Data.Setup.SystemRoleTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class SystemRoleBL
    {
        private SystemRoleTableAdapter systemRoleAdapter = new SystemRoleTableAdapter();

        protected SystemRoleTableAdapter SystemRoleAdapter
        {
            get
            {
                if (systemRoleAdapter == null)
                {
                    systemRoleAdapter = new SystemRoleTableAdapter();
                }

                return systemRoleAdapter;
            }

        }


        public string GetSystemRoleNameByID(int iSystemRoleId)
        {
            return SystemRoleAdapter.GetSystemRoleById((iSystemRoleId)).ToString();

        }


        [System.ComponentModel.DataObjectMethodAttribute
         (System.ComponentModel.DataObjectMethodType.Select, true)]
        public SystemRole.SystemRoleDataTable GetSystemRoles()
        {
            return SystemRoleAdapter.GetSystemRole(); ;
        }
    }
}
