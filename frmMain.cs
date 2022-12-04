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
            OpenChildFrom(new frmAdvise(), sender);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmQuestion(), sender);
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmRule(), sender);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new frmResult(), sender);
        }

        private void btnAnswers_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(new frmAnswer(), sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildFrom(new frmAdvise(), sender);
        }
    }
}
