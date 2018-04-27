using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ESOFT_PROJECT
{
    public partial class frmstore : Form
    {
        public frmstore()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "SerialNo")
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT SerialNo,Style,Size,Price,Quantity FROM Bettans_store  WHERE SerialNo LIKE'" + txtbox.Text + "%'", con);
                DataTable storedetails = new DataTable();
                sda.Fill(storedetails);
                dataGridView1.DataSource = storedetails;
            }
            else if(comboBox1.Text == "Style")
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT SerialNo,Style,Size,Price,Quantity FROM Bettans_store WHERE Style LIKE'" + txtbox.Text + "%'", con);
                DataTable storedetails = new DataTable();
                sda.Fill(storedetails);
                dataGridView1.DataSource = storedetails;
            }
           
            else if(comboBox1.Text == "Size")
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT SerialNo,Style,Size,Price,Quantity FROM Bettans_store WHERE Size LIKE'" + txtbox.Text + "%'", con);
                DataTable storedetails = new DataTable();
                sda.Fill(storedetails);
                dataGridView1.DataSource = storedetails;
            }
            
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmstoredetails frm = new frmstoredetails();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }
    }

