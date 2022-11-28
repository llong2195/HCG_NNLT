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
    public partial class frmRule : Form
    {
        RuleController ruleController = new RuleController();
        ResultController resultController = new ResultController();
        public frmRule()
        {
            InitializeComponent();
        }

        private void getData()
        {
            try
            {
                DataSet rs = ruleController.getAll("rule");
                dgv.DataSource = rs.Tables["rule"];
                DataSet ts = resultController.getAll("result");
                cbbResult.DataSource = ts.Tables["result"];
                cbbResult.DisplayMember = "ResultName";
                cbbResult.ValueMember = "ResultID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText(Boolean check)
        {
            txtRuleID.Text = "";
            txtRules.Text = "";
            cbbResult.SelectedText = "";

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
                string Rules = txtTimKiem.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@Rules", Rules));
                DataSet rs = ruleController.search("rule", data);
                dgv.DataSource = rs.Tables["rule"];
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
                String RuleID = txtRuleID.Text;
                String Rules = txtRules.Text.Trim();
                String ResultID = cbbResult.SelectedValue.ToString();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@RuleID", RuleID));
                data.Add(new SqlParameter("@Rules", Rules));
                data.Add(new SqlParameter("@ResultID", ResultID));
                int rs = ruleController.insertData(data);
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
                String RuleID = txtRuleID.Text.Trim();
                String Rules = txtRules.Text.Trim();
                String ResultID = cbbResult.SelectedValue.ToString();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@RuleID", RuleID));
                data.Add(new SqlParameter("@Rules", Rules));
                data.Add(new SqlParameter("@ResultID", ResultID));
                int rs = ruleController.updateData(data);
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
                String RuleID = txtRuleID.Text.Trim();
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@RuleID", RuleID));

                int rs = ruleController.deleteData(data);
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
                txtRuleID.Text = dgv.Rows[idx].Cells["RuleID"].Value.ToString();
                txtRules.Text = dgv.Rows[idx].Cells["Rules"].Value.ToString();
                cbbResult.SelectedValue = dgv.Rows[idx].Cells["ResultID"].Value.ToString();
                //numSoLuongTon.Value = Convert.ToInt32(dgvWarehouse.Rows[idx].Cells["SoLuongTon"].Value.ToString());

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
