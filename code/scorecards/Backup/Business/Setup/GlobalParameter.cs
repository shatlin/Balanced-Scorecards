using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using Data.Setup;

/// <summary>
/// Summary description for GlobalParameter
/// </summary>
/// 
namespace Business.Setup
{
    public class GlobalParameter
    {
       

        public DataSet GetGlobalParameters()
        {
            try
            {
                return GlobalParameterDB.GetGlobalParameters();
            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }

        }

        public DataSet GetGlobalParameterDetails(int iGlobalParameterId)
        {

            try
            {
                return GlobalParameterDB.GetGlobalParameterDetails(iGlobalParameterId);
            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }


        }

        public void UpdateGlobalParameter(int iGlobalParameterDetailId)
        {
            try
            {
                GlobalParameterDB.UpdateGlobalParameter(iGlobalParameterDetailId);
            }
            catch (Exception objException)
            {

                throw new Exception(objException.Message);
            }

        }

    }
}