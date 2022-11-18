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
    public partial class frmQuestion : Form
    {
        QuestionController questionController = new QuestionController();
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void getData()
        {
            try
            {
                DataSet rs = questionController.getAll("rule");
                dgv.DataSource = rs.Tables["rule"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText(Boolean check)
        {
            txtQuestionID.Text = "";
            rtbName.Text = "";

            btnAdd.Enabled = check;
            btnEdit.Enabled = !check;
            btnDel.Enabled = !check;
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtTimKiem.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@Name", Name));
                DataSet rs = questionController.search("question", data);
                dgv.DataSource = rs.Tables["question"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String QuestionID = txtQuestionID.Text.Trim();
                String Name = rtbName.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@Name", Name));
                data.Add(new SqlParameter("@QuestionID", QuestionID));
                int rs = questionController.insertData(data);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                String QuestionID = txtQuestionID.Text.Trim();
                String Name = rtbName.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@QuestionID", QuestionID));
                data.Add(new SqlParameter("@Name", Name));
                int rs = questionController.updateData(data);
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
                String QuestionID = txtQuestionID.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@QuestionID", QuestionID));

                int rs = questionController.deleteData(data);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                clearText(false);
                txtQuestionID.Text = dgv.Rows[idx].Cells["QuestionID"].Value.ToString();
                rtbName.Text = dgv.Rows[idx].Cells["Name"].Value.ToString();

            }
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }
    }
}
