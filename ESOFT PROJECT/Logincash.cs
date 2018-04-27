using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESOFT_PROJECT
{
    public partial class frmlogin_cash : Form
    {
        public frmlogin_cash()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            if (password == "cashier")
            {
                frmcashier frm = new frmcashier();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The password is incorrected.Please try again");
                txtpassword.Clear();
            }
                

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             frmuser_selection frm = new frmuser_selection();
            frm.Show();
            this.Hide();
        }
    }
}
