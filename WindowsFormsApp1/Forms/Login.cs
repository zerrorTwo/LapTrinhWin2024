using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pnLogin.FillColor = Color.FromArgb(140, Color.Black);
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            pnLogin.Height += 50;
            btnLogin.Visible = false;
            btnRegister.Visible = false;
            lbBackk.Visible = true;
            btnCofirm.Visible = true;
            tbComfimPass.Visible = true;
        }

        private void lbBack_Click(object sender, EventArgs e)
        {

        }

        private void lbBackk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbBackk.Visible = false;
            btnCofirm.Visible = false;
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            tbComfimPass.Visible = false;
            pnLogin.Height -= 50;

            tbPassword.Text = "";
            tbUserName.Text = "";
            tbComfimPass.Text = "";
        }
    }
}
