using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BCS2017.Repository
{
    public class ADOContext
    {
        public ADOContext()
        {
            string strcon =
    ConfigurationManager.ConnectionStrings["CISDB"].ConnectionString;
            SqlConnection DbConnection = new SqlConnection(strcon);



        }

        //     public DataTable ExecuteSQLProc(string Procname)
        //     {

        //         string strcon =
        //ConfigurationManager.ConnectionStrings["CISDB"].ConnectionString;
        //         SqlConnection DbConnection = new SqlConnection(strcon);
        //         using (var conn = new SqlConnection(strcon))
        //         using (var command = new SqlCommand("ProcedureName", conn)
        //         {
        //             CommandType = CommandType.StoredProcedure

        //         })
        //         {
        //             SqlDataAdapter adp=new SqlDataAdapter()
        //             conn.Open();
        //             command.ExecuteNonQuery();
        //         }



        //     }

    }
}