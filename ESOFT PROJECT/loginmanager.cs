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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string password = txtpassword.Text;
            if(password=="manager")
            {
                 frmmanagement frm=new frmmanagement();
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

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
