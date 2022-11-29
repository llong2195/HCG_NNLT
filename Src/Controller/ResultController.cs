using HCG_NNLT.Src.DbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;  
namespace WindowsFormsApp1.Controller
{
    public class ResultController
    {
        dbConnect conn = new dbConnect();
        public ResultController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Results";
                rs = conn.getData(sql, table_name, null);
                return rs;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public DataSet getById(string table_name, List<SqlParameter> data)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select top 1 * from tbl_Results where ResultID = @ResultID";
                rs = conn.getData(sql, table_name, data);
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
                string sql = "insert into tbl_Results(ResultId, Description, ResultName) values (@ResultId, @Description, @ResultName)";
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
                string sql = "update tbl_Results set Description = @Description, ResultName = @ResultName where ResultId = @ResultId";
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
                string sql = "delete tbl_Results where ResultId = @ResultId";
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
                string sql = "select * from tbl_Results where ResultName like '%' + @ResultName + '%'";
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
