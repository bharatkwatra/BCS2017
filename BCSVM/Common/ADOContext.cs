using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BCSVM.Common
{
    public class ADOContext
    {

        public string readConfig()
        {
            string strcon =
    ConfigurationManager.ConnectionStrings["BCSDB"].ConnectionString;
            SqlConnection DbConnection = new SqlConnection(strcon);

            return strcon;

        }

        public DataTable ExecSQLProc(string spName, SqlParameter[] param)
        {
            SqlConnection connection = null;
            DataTable dt = new DataTable();
            try
            {
                connection = new SqlConnection(readConfig());
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);
                command.CommandTimeout = 0;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                //throw;
                if (ex.Message.Split('\n').Length > 1)
                    dt.Columns.Add(ex.Message.Split('\n')[1], this.GetType());
                else
                    dt.Columns.Add(ex.Message, this.GetType());
            }
            catch (Exception ex)
            {
                // throw;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dt;
        }

        public DataSet ExecSQLProcReturnDS(string spName, SqlParameter[] param)
        {
            SqlConnection connection = null;
            DataSet ds = new DataSet();
            try
            {
                connection = new SqlConnection(readConfig());
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = spName;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);
                command.CommandTimeout = 0;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return ds;
        }

    }
}
