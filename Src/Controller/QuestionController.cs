﻿using HCG_NNLT.Src.DbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace WindowsFormsApp1.Controller
{
    public class QuestionController
    {
        dbConnect conn = new dbConnect();
        public QuestionController()
        {

        }
        public DataSet getAll(string table_name)
        {
            try
            {
                DataSet rs = new DataSet();
                string sql = "select * from tbl_Questions";
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
                string sql = "select top 1 from tbl_Questions where QuestionId = @Id";
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
