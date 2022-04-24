using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for LoginDB
/// </summary>
/// 
namespace Data.Setup
{
    public class LoginDB : SystemManagerDB
    {


        public static bool IsFirstTimeUse()
        {

            int isFirstTimeuse;

            try
            {
                LoginDB loginDB = new LoginDB();
                sqlComm.CommandText = "Select * From FirstLoginCheck";
                sqlAdap.SelectCommand = sqlComm;
                isFirstTimeuse = (int)sqlComm.ExecuteScalar();
                sqlConn.Close();
            }
            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }

            return Convert.ToBoolean(isFirstTimeuse);

        }

        public static bool CreateFirstSuperUser(string strUserId, string strPassword)
        {
            LoginDB loginDB = new LoginDB();

            SqlTransaction sqlTran = sqlConn.BeginTransaction();

            try
            {
                sqlComm.Transaction = sqlTran;
                sqlComm.CommandText = "insert into employee( useridcode,password) values (@useridCode,@Password)";
                sqlAdap.InsertCommand = sqlComm;
                sqlAdap.InsertCommand.Parameters.Add("@useridCode", SqlDbType.VarChar, 20).Value = strUserId;
                sqlAdap.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = strPassword;

                sqlComm.ExecuteNonQuery();

                sqlComm.CommandText = " update FirstLoginCheck set isFirstLogon=0";
                sqlAdap.UpdateCommand = sqlComm;
                sqlComm.ExecuteNonQuery();
                sqlTran.Commit();


            }
            catch (Exception objException)
            {
                sqlTran.Rollback();
                throw new Exception(objException.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            return true;

        }

        public static int ValidateUser(string AppUserOrgId, string Password)
        {
            LoginDB loginDB = new LoginDB();
            bool isValidated = false;
            int iAppUserId=0; 
            try
            {
               sqlComm.CommandText = "Select AppUserId, AppUserOrgId,Password,SystemRoldId From AppUser where AppUserOrgId=@AppUserOrgId and password=@Password";
               sqlAdap.SelectCommand = sqlComm;
               sqlAdap.SelectCommand.Parameters.Add("@AppUserOrgId", SqlDbType.VarChar).Value = AppUserOrgId;
               sqlAdap.SelectCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
               SqlDataReader sqlReader = sqlComm.ExecuteReader();


               if (sqlReader.HasRows)
               {
                   while (sqlReader.Read())
                   {
                       iAppUserId = Convert.ToInt32(sqlReader[0]);
                      
                   }

                    isValidated = true;
                }
            }

            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            if (isValidated)
            {
                return iAppUserId;
            }
            else
            {
                return 0;
            }

        }

        public static int GetSystemRole(int iAppUserId)
        {
            LoginDB loginDB = new LoginDB();
            int iSystemRoleId = 0;
            
            try
            {
                sqlComm.CommandText = "Select SystemRoldId From AppUser where AppUserId=@AppUserId";
                sqlAdap.SelectCommand = sqlComm;
                sqlAdap.SelectCommand.Parameters.Add("@AppUserId", SqlDbType.VarChar).Value = iAppUserId;
                SqlDataReader sqlReader = sqlComm.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        iSystemRoleId = Convert.ToInt32(sqlReader[0]);

                    }
                }
            }

            catch (Exception objException)
            {
                throw new Exception(objException.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            return iSystemRoleId;
        }
    }
}

