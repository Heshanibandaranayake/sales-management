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
    public partial class frmloginpage : Form
    {
        public frmloginpage()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;
            if (email == "user@bettans.lk" && password == "user123")
            {
                frmuser_selection us = new frmuser_selection();
                us.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login not success.Please try again");
                txtemail.Clear();
                txtpassword.Clear();
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            frmhomepage frm = new frmhomepage();
            frm.Show();
            this.Hide();
        }
            
            
        }
    }

