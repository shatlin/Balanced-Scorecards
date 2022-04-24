using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;

namespace Business.Setup
{
    public class LoginManager
    {
        public bool IsFirstTimeUse()
        {
            bool isFirstTimeuse = false;

            

            try
            {
                isFirstTimeuse = LoginDB.IsFirstTimeUse();
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
            return isFirstTimeuse;

        }

        public bool CreateFirstSuperUser(string strUserId, string strPassword)
        {
            try
            {
                return LoginDB.CreateFirstSuperUser(strUserId, strPassword);
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
        }


        public int ValidateUser(string strUserId, string strPassword)
        {

            try
            {
                return LoginDB.ValidateUser(strUserId, strPassword);
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
        }

        public int GetSystemRole(int iAppUserId)
        {
            try
            {
                return LoginDB.GetSystemRole(iAppUserId);
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
            
        }
    }




}
