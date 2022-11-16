using HCG_NNLT.Src.Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCG_NNLT
{
    public partial class frmMain : Form
    {
        Button currentButton;
        Form activeForm;
        public frmMain()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = Color.LightSkyBlue;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void DisableButton()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.RoyalBlue;
                }
            }
        }
        private void OpenChildFrom(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelController.Controls.Add(childForm);
            this.panelController.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            frmRule frm = new frmRule();
            //frm.MdiParent= this;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(frm);
            this.panel1.Tag = frm;
            frm.BringToFront();
            frm.Show();
            frm.Show();
        }
    }
}
