using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Data.Setup
{
    public class SystemManagerDB
    {
        protected static string strConnectionString;
        protected static SqlConnection sqlConn;
        protected static SqlCommand sqlComm;
        protected static SqlDataAdapter sqlAdap;

        public SystemManagerDB()
        {
            strConnectionString = "Data Source=diasha;Initial Catalog=iScoreDB;Integrated Security=True";
            sqlConn = new SqlConnection();
            sqlComm = new SqlCommand();
            sqlAdap = new SqlDataAdapter();
            sqlConn.ConnectionString = strConnectionString;
            sqlComm.Connection = sqlConn;
            sqlComm.CommandType = CommandType.Text;
            sqlConn.Open();
        }
    }
}

