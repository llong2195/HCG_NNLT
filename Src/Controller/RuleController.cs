using HCG_NNLT.Src.DbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WindowsFormsApp1.Controller
{
    public class RuleController
    {
        dbConnect conn = new dbConnect();
        public RuleController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Rules";
                rs = conn.getData(sql, table_name, null);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
