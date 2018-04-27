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
    public partial class frmmanagement : Form
    {
        public frmmanagement()
        {
            InitializeComponent();
        }

        private void btnstade_P_Click(object sender, EventArgs e)
        {
            frmStaffdetals_personal frm = new frmStaffdetals_personal();
            frm.Show();
            this.Hide();
        }

        private void btnstade_O_Click(object sender, EventArgs e)
        {
            frmstaffdetails_O frm = new frmstaffdetails_O();
            frm.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//This pictureBox displays "Back"
        {
            frmuser_selection frm = new frmuser_selection();
            frm.Show();
            this.Hide();
        }
    }
}
