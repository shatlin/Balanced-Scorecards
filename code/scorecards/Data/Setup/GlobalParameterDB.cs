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
    public class GlobalParameterDB : SystemManagerDB
    {
        public static DataSet GetGlobalParameters()
        {

       
            DataSet dsGlobalParameters = new DataSet();
            sqlComm.CommandText = "Select * From GlobalParameter";
            sqlAdap.SelectCommand = sqlComm;
            sqlComm.CommandType = CommandType.Text;

            try
            {
                sqlAdap.Fill(dsGlobalParameters);
                return dsGlobalParameters;
            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }
            finally
            {
                sqlConn.Close();
            }

        }

        public static DataSet GetGlobalParameterDetails(int iGlobalParameterId)
        {

          
            DataSet dsGlobalParameters = new DataSet();

            sqlComm.CommandText = "Select GlobalParameterDetailId,GlobalParameterValue,Example,Isselected From GlobalParameterDetail where GlobalParameterId= @GlobalParameterId";


            try
            {
                sqlAdap.SelectCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlAdap.SelectCommand.Parameters.Add("@GlobalParameterId", SqlDbType.Int).Value = iGlobalParameterId;

                sqlAdap.Fill(dsGlobalParameters);
                return dsGlobalParameters;
            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public static void UpdateGlobalParameter(int GlobalParameterDetailId)
        {

           
            SqlTransaction sqlTran = sqlConn.BeginTransaction();
            try
            {
                sqlComm.Transaction = sqlTran;
                sqlAdap.UpdateCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlAdap.UpdateCommand.Parameters.Add("@GlobalParameterDetailId", SqlDbType.Int).Value = GlobalParameterDetailId;
                sqlComm.CommandText = "Update GlobalParameterDetail set isSelected ='No' where isSelected='Yes' and GlobalParameterId= (select distinct GlobalParameterId from GlobalParameterDetail where GlobalParameterDetailId=@GlobalParameterDetailId)";

                sqlComm.ExecuteNonQuery();

                sqlAdap.UpdateCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "Update GlobalParameterDetail set isSelected ='Yes' where GlobalParameterDetailId=@GlobalParameterDetailId";
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


        }
    }

}