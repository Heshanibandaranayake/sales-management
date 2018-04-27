using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace ESOFT_PROJECT
{
    public partial class frmsearch : Form
    {
        public frmsearch()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
       
        private void SEARCH()
        {
            con.Open();
            string query_togrid = "SELECT * FROM STAFFDETAILS_OFFICIAL WHERE EmpNo='" + txtsearch.Text + "'";
            adp = new SqlDataAdapter(query_togrid, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SEARCH();
            con.Open();
             string query_togrid = "SELECT EmpID,Name,BasicSalary,Year,Month,OT_Hours,OT_Rate,OT_Amount,NetSalary FROM staffdetailsP INNER JOIN STAFFDETAILS_OFFICIAL ON staffdetailsP.EmpNo = STAFFDETAILS_OFFICIAL.EmpNo WHERE EmpID ='" + txtsearch.Text + "'"; 
             adp = new SqlDataAdapter(query_togrid, con);
             DataTable table = new DataTable();
             adp.Fill(table);
             dataGridView1.DataSource = table;
           

            dataGridView1.Columns[0].HeaderText="EmpID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "BasicSalary";
            dataGridView1.Columns[3].HeaderText = "Year";
            dataGridView1.Columns[4].HeaderText = "Month";
            dataGridView1.Columns[5].HeaderText = "OT_Hours";
            dataGridView1.Columns[6].HeaderText = "OT_Rate";
            dataGridView1.Columns[7].HeaderText = "OT_Amount";
            dataGridView1.Columns[8].HeaderText = "NetSalary";
            
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)//This pictureBox displays "Back"
        {
            frmmanagement frm = new frmmanagement();
            frm.Show();
            this.Hide();
        }
    }
}
