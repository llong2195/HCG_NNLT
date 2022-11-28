using HCG_NNLT.Src.DbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public int insertData(List<SqlParameter> data)
        {
            try
            {
                string sql = "insert into tbl_Rules(RuleId, ResultID, Rules) values (@RuleId, @ResultID, @Rules)";
                int rs = (int)conn.UpdateData(sql, data);
                return rs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int updateData(List<SqlParameter> data)
        {
            try
            {
                string sql = "update tbl_Rules set ResultID = @ResultID, Rules = @Rules where RuleId = @RuleId";
                int rs = (int)conn.UpdateData(sql, data);
                return rs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int deleteData(List<SqlParameter> data)
        {
            try
            {
                string sql = "delete tbl_Rules where RuleId = @RuleId";
                int rs = (int)conn.UpdateData(sql, data);
                return rs;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataSet search(string table_name, List<SqlParameter> data)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Rules where Rules like '%' + @Rules + '%'";
                rs = conn.getData(sql, table_name, data);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
