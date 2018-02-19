using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BCSVM.Common;
using System.Data.SqlClient;

namespace BCSVM.IndustriesRepo
{
    public class IndRepository
    {
        public static  DataTable GetUserData(int ModuleID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ModuleID", ModuleID);
            ADOContext dut = new ADOContext();
            DataTable dtdata = new DataTable();
            dtdata = dut.ExecSQLProc("USP_GETCategoryDropDown", param);
            return dtdata;
        }
        public void TestFunction()
        {
            int a=0;
            int b=0;

        }
    }
}
