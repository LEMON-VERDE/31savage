using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31Savage
{
    public partial class Login : Form
    {
        int NbUsr;
        public Login()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;

            lbl_Usr1.Visible = true;
            lbl_NomUsr1.Visible = true;
            lbl_Usr1.Enabled = false;
            lbl_NomUsr1.Enabled = false;

            lbl_Usr2.Visible = true;
            txtBox_NomUsr2.Visible = true;
        }

        private void txtBox_NomUsr2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr2.Text))
            {
                lbl_Usr2.Enabled = false;
                txtBox_NomUsr2.Enabled = false;

                lbl_Usr3.Visible = true;
                txtBox_NomUsr3.Visible = true;

                btn_nav.Visible = true;
                NbUsr = 1;
            }
        }

        private void txtBox_NomUsr3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr3.Text))
            {
                lbl_Usr3.Enabled = false;
                txtBox_NomUsr3.Enabled = false;

                lbl_Usr4.Visible = true;
                txtBox_NomUsr4.Visible = true;

                NbUsr = 2;
            }
        }

        private void txtBox_NomUsr4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr4.Text))
            {
                lbl_Usr4.Enabled = false;
                txtBox_NomUsr4.Enabled = false;

                lbl_Usr5.Visible = true;
                txtBox_NomUsr5.Visible = true;

                NbUsr = 3;
            }
        }

        private void txtBox_NomUsr5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr5.Text))
            {
                lbl_Usr5.Enabled = false;
                txtBox_NomUsr5.Enabled = false;

                lbl_Usr6.Visible = true;
                txtBox_NomUsr6.Visible = true;

                NbUsr = 4;
            }
        }

        private void txtBox_NomUsr6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr6.Text))
            {
                lbl_Usr6.Enabled = false;
                txtBox_NomUsr6.Enabled = false;

                lbl_Usr7.Visible = true;
                txtBox_NomUsr7.Visible = true;

                NbUsr = 5;
            }
        }

        private void txtBox_NomUsr7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr7.Text))
            {
                lbl_Usr7.Enabled = false;
                txtBox_NomUsr7.Enabled = false;

                lbl_Usr8.Visible = true;
                txtBox_NomUsr8.Visible = true;

                NbUsr = 6;
            }
        }

        private void txtBox_NomUsr8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr8.Text))
            {
                lbl_Usr8.Enabled = false;
                txtBox_NomUsr8.Enabled = false;

                lbl_Usr9.Visible = true;
                txtBox_NomUsr9.Visible = true;

                NbUsr = 7;
            }
        }

        private void txtBox_NomUsr9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtBox_NomUsr9.Text))
            {
                lbl_Usr9.Enabled = false;
                txtBox_NomUsr9.Enabled = false;

                NbUsr = 8;
            }
        }

        private void btn_nav_Click(object sender, EventArgs e)
        {
        }
    }
}
