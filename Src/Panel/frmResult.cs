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
    public partial class frmResult : Form
    {
        ResultController resultController = new ResultController();

        public frmResult()
        {
            InitializeComponent();
        }
        private void getData()
        {
            try
            {
                DataSet rs = resultController.getAll("result");
                dgv.DataSource = rs.Tables["result"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText(Boolean check)
        {
            txtResultID.Text = "";
            rtbName.Text = "";
            rtbDescription.Text = "";
            btnAdd.Enabled = check;
            btnEdit.Enabled = !check;
            btnDel.Enabled = !check;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String ResultID = txtResultID.Text.Trim();
                String Name = rtbName.Text.Trim();
                String Description = rtbDescription.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@ResultName", Name));
                data.Add(new SqlParameter("@Description", Description));
                data.Add(new SqlParameter("@ResultID", ResultID));
                int rs = resultController.insertData(data);
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

        private void frmResult_Load(object sender, EventArgs e)
        {
            getData();
            clearText(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                String ResultID = txtResultID.Text.Trim();
                String Name = rtbName.Text.Trim();
                String Description = rtbDescription.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@ResultName", Name));
                data.Add(new SqlParameter("@Description", Description));
                data.Add(new SqlParameter("@ResultID", ResultID));
                int rs = resultController.updateData(data);
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
                String ResultID = txtResultID.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@ResultID", ResultID));

                int rs = resultController.deleteData(data);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtTimKiem.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@ResultName", Name));
                DataSet rs = resultController.search("result", data);
                dgv.DataSource = rs.Tables["result"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                clearText(false);
                txtResultID.Text = dgv.Rows[idx].Cells["ResultID"].Value.ToString();
                rtbName.Text = dgv.Rows[idx].Cells["ResultName"].Value.ToString();
                rtbDescription.Text = dgv.Rows[idx].Cells["Description"].Value.ToString();

            }
        }
    }
}
