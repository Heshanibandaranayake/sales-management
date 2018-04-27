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
    public partial class frmuser_selection : Form
    {
        public frmuser_selection()
        {
            InitializeComponent();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void btnstorekeeper_Click(object sender, EventArgs e)
        {
            frmlogin_storekeeper frm = new frmlogin_storekeeper();
            frm.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmloginpage frm = new frmloginpage();//when click the "back",it will link to login page
            frm.Show();
            this.Hide();
        }

        private void btncashier_Click(object sender, EventArgs e)
        {
            frmlogin_cash frm = new frmlogin_cash();
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmuser_selection_Load(object sender, EventArgs e)
        {

        }
    }
}
