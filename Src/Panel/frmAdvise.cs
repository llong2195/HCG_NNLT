using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace HCG_NNLT.Src.Panel
{
    public partial class frmAdvise : Form
    {
        public frmAdvise()
        {
            InitializeComponent();
        }
        QuestionController questionController = new QuestionController();

        private void loadData(String QuestionID)
        {
            loadQuestion(QuestionID);
            loadAswer(QuestionID);
        }
        private void loadQuestion(String QuestionID)
        {
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@QuestionID", QuestionID));
            DataSet rs = questionController.getById("question", data);
            txtQuestion.Text = rs.Tables["question"].Rows[0]["QuestionName"].ToString();
        }

        private void loadAswer(String CurrentQuestion)
        {
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@CurrentQuestion", "CurrentQuestion"));
            DataSet rs = questionController.getById("data", data);
            dgv.DataSource = rs.Tables["data"];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdvise_Load(object sender, EventArgs e)
        {
            loadData(QuestionID);
        }
    }
}
