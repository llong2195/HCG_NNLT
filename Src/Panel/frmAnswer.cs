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
    public partial class frmAnswer : Form
    {
        QuestionController questionController = new QuestionController();
        AnswerController answerController = new AnswerController();
        public frmAnswer()
        {
            InitializeComponent();
        }

        private void getData()
        {
            try
            {
                DataSet rs = answerController.getAll("answer");
                DataSet ts = questionController.getAll("curentQuestion");
                DataSet ds = questionController.getAll("nextQuestion");
                dgv.DataSource = rs.Tables["answer"];
                cbbCrQ.DataSource = ts.Tables["curentQuestion"];
                cbbCrQ.DisplayMember = "QuestionName";
                cbbCrQ.ValueMember = "QuestionID";

                cbbNtQ.DataSource = ds.Tables["nextQuestion"];
                cbbNtQ.DisplayMember = "QuestionName";
                cbbNtQ.ValueMember = "QuestionID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText(Boolean check)
        {
            txtAnswerID.Text = "";
            rtbName.Text = "";
            cbbCrQ.SelectedText = "";
            cbbNtQ.SelectedText = "";
            btnAdd.Enabled = check;
            btnEdit.Enabled = !check;
            btnDel.Enabled = !check;
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String AnswerID = txtAnswerID.Text.Trim();
                String Name = rtbName.Text.Trim();
                String CrQ = cbbCrQ.SelectedValue.ToString();
                String NtQ = cbbNtQ.SelectedValue.ToString();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@AnswerName", Name));
                data.Add(new SqlParameter("@AnswerID", AnswerID));
                data.Add(new SqlParameter("@CurrentQuestion", CrQ));
                data.Add(new SqlParameter("@NextQuestion", NtQ));
                int rs = answerController.insertData(data);
                if (rs <= 0)
                {
                    MessageBox.Show("Không Thành Công !");
                }
                else
                {
                    getData();
                    clearText(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR : " + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmAnswer_Load(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                String AnswerID = txtAnswerID.Text.Trim();
                String Name = rtbName.Text.Trim();
                String CrQ = cbbCrQ.SelectedValue.ToString();
                String NtQ = cbbNtQ.SelectedValue.ToString();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@AnswerID", AnswerID));
                data.Add(new SqlParameter("@AnswerName", Name));
                data.Add(new SqlParameter("@CurrentQuestion", CrQ));
                data.Add(new SqlParameter("@NextQuestion", NtQ));
                int rs = answerController.updateData(data);
                if (rs <= 0)
                {
                    MessageBox.Show("Không Thành Công !");
                }
                else
                {
                    getData();
                    clearText(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR : " + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                String AnswerID = txtAnswerID.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@AnswerID", AnswerID));

                int rs = answerController.deleteData(data);
                if (rs <= 0)
                {
                    MessageBox.Show("Không Thành Công !");
                }
                else
                {
                    getData();
                    clearText(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR : " + ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                clearText(false);
                txtAnswerID.Text = dgv.Rows[idx].Cells["AnswerID"].Value.ToString();
                rtbName.Text = dgv.Rows[idx].Cells["AnswerName"].Value.ToString();
                cbbCrQ.SelectedValue = dgv.Rows[idx].Cells["CurrentQuestion"].Value.ToString();
                cbbNtQ.SelectedValue = dgv.Rows[idx].Cells["NextQuestion"].Value.ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtTimKiem.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@AnswerName", Name));
                DataSet rs = answerController.search("answer", data);
                dgv.DataSource = rs.Tables["answer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
