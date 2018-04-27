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
    public partial class frmlogin_storekeeper : Form
    {
        public frmlogin_storekeeper()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            if (password == "storekeeper")
            {
                frmstoredetails frm = new frmstoredetails();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The password is incorrected.Please try again");
                txtpassword.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)//This pictureBox displays "Back"
        {
            frmuser_selection frm = new frmuser_selection();
            frm.Show();
            this.Hide();
        }
    }
}
