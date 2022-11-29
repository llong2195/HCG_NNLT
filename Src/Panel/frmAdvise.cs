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
        AnswerController answerController = new AnswerController();
        QuestionController questionController = new QuestionController();
        RuleController ruleController = new RuleController();
        ResultController resultController = new ResultController();
        string CheckRule = "";
        public frmAdvise()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
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
=======

        private void btnStart_Click(object sender, EventArgs e)
        {
            formLoad(true);
            DataSet rs = questionController.getFirstQuestion("question");
            groupBox1.Text = rs.Tables["question"].Rows[0]["QuestionName"].ToString();
            string QuestionID = rs.Tables["question"].Rows[0]["QuestionID"].ToString();
            List<SqlParameter> data = new List<SqlParameter>();
            data.Add(new SqlParameter("@QuestionID", QuestionID));
            DataSet ts = answerController.getByQuestionId("answer", data);
            dataGridView1.DataSource = ts.Tables["answer"];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdvise_Load(object sender, EventArgs e)
        {
            formLoad(false);
        }

        private void formLoad(Boolean a)
        {
            groupBox1.Visible = a;
            groupBox2.Visible = a;
            btnChoose.Visible = a;
            groupBox3.Visible = a;
            btnStart.Visible = !a;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                string AnswerName = r.Cells["AnswerName"].Value.ToString();
                string AnswerID = r.Cells["AnswerID"].Value.ToString();
                string NextQuestion = r.Cells["NextQuestion"].Value.ToString();
                listBox1.Items.Add(AnswerName);
                CheckRule += CheckRule == "" ? AnswerID : "&" + AnswerID;
                if(btnChoose.Text == "Làm lại")
                {
                    formLoad(false);
                    btnChoose.Text = "Chọn";
                    return;
                }
                if (NextQuestion != "")
                {
                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@QuestionID", NextQuestion));
                    DataSet ts = answerController.getByQuestionId("answer", data);
                    dataGridView1.DataSource = ts.Tables["answer"];

                    List<SqlParameter> data1 = new List<SqlParameter>();
                    data1.Add(new SqlParameter("@QuestionID", NextQuestion));
                    DataSet rs = questionController.getById("question", data1);
                    groupBox1.Text = rs.Tables["question"].Rows[0]["QuestionName"].ToString();
                }
                else
                {
                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@Rules", CheckRule));
                    DataSet rs = ruleController.search("rule", data);
                    string resultID = rs.Tables["rule"].Rows[0]["ResultID"].ToString();

                    List<SqlParameter> data1 = new List<SqlParameter>();
                    data1.Add(new SqlParameter("@ResultID", resultID));
                    DataSet ts = resultController.getById("result", data1);
                    listBox2.Items.Add(ts.Tables["result"].Rows[0]["ResultName"].ToString());

                    btnChoose.Text = "Làm lại";
                }
                
            }



        }
>>>>>>> origin/kendz
    }
}
