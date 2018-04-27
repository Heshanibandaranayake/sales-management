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
    public partial class frmStaffdetals_personal : Form
    {
        public frmStaffdetals_personal()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        string Gender;
        int Emp_ID;
        

        private void Form10_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT(MAX(EmpID)+1)AS EmpID FROM staffdetailsP", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["EmpID"] is DBNull)
            {
                Emp_ID = 1;
            }
            else
            {
                Emp_ID = Convert.ToInt16(reader["EmpID"]);
            }

            if (reader.HasRows == true)
            {
                txtempid.Text = reader["EmpID"].ToString();

                reader.Close();
            }
            
            con.Close();

           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                int empid = int.Parse(txtempid.Text);
                string name = txtname.Text;
                string nic = txtnic.Text;
                int tel = int.Parse(txttel.Text);
                string address = txtaddress.Text;
                int empno = int.Parse(txtemp.Text);
                con.Open();
                string query_update = "UPDATE staffdetailsP SET Name='" + name + "',NIC='" + nic + "',Tel='" + tel + "',Address='" + address + "',EmpNo='" + empno + "'WHERE EmpID='" + empid + "'";
                cmd = new SqlCommand(query_update,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch 
            {
                MessageBox.Show("Error while updating", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
               {
                  con.Close();
               }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int empid = int.Parse(txtempid.Text);
                con.Open();
                string query_delete = "DELETE FROM staffdetailsP WHERE EmpID='" + empid + "'";
                cmd = new SqlCommand(query_delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


               cmd = new SqlCommand("SELECT(MAX(EmpID)+1)AS EmpID FROM staffdetailsP", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader["EmpID"] is DBNull)
                {
                    Emp_ID = 1;
                }
                else
                {
                    Emp_ID = Convert.ToInt16(reader["EmpID"]);
                }

                if (reader.HasRows == true)
                {
                    txtempid.Text = reader["EmpID"].ToString();

                    reader.Close();
                }
                
            }

            catch 
            {
                MessageBox.Show("Error while deleting" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
              con.Close();
             }
             
             

        }
        private void SHOWALLDGV()
        {
            con.Open();
            string query_togrid = "SELECT * FROM staffdetailsP";
            adp = new SqlDataAdapter(query_togrid, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            gvstaffdetailsP.DataSource = table;
            con.Close();
        }
        private void SEARCH()
        {
            try
            {
                con.Open();
                string query_togrid = "SELECT * FROM staffdetailsP WHERE EmpID='" + txtsearch.Text + "'";
                adp = new SqlDataAdapter(query_togrid, con);
                DataTable table = new DataTable();
                adp.Fill(table);
                gvstaffdetailsP.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Please check EmpID again.The EmpID might be lost or the EmpID is incorrected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
           
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmstaffdetails_O frm = new frmstaffdetails_O();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//This pictureBox displays "Back"
        {
            frmmanagement frm = new frmmanagement();
            frm.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT(MAX(EmpID)+1)AS EmpID FROM staffdetailsP", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader["EmpID"] is DBNull)
                {
                    Emp_ID = 1;
                }
                else
                {
                    Emp_ID = Convert.ToInt16(reader["EmpID"]);
                }
                reader.Close();
                
                    
                string name = txtname.Text;
                string nic = txtnic.Text;
                int tel = int.Parse(txttel.Text);
                string address = txtaddress.Text;
                int empno = int.Parse(txtemp.Text);
                string EMPID = txtempid.Text;
            
                if (radiofemale.Checked == true)
                {
                    Gender = "F";
                }
                else if (radiomale.Checked == true)
                {
                    Gender = "M";
                }
                if (EMPID.Length == 4)
                {
                    string query_insert = "INSERT INTO staffdetailsP (EmpID,Name,NIC,Tel,Address,Gender,EmpNo) values ('" + Emp_ID + "','" + name + "','" + nic + "','" + tel + "','" + address + "','" + Gender + "','" + empno + "')";
                    cmd = new SqlCommand(query_insert, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error while Saving","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
   
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SHOWALLDGV();
            CLEAR();
            con.Open();
            cmd = new SqlCommand("SELECT(MAX(EmpID)+1)AS EmpID FROM staffdetailsP", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["EmpID"] is DBNull)
            {
                Emp_ID = 1;
            }
            else
            {
                Emp_ID = Convert.ToInt16(reader["EmpID"]);
            }

            if (reader.HasRows == true)
            {
                txtempid.Text = reader["EmpID"].ToString();

                reader.Close();
            }
            

            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)//textBox7 dislpays the search option
        {

        }

        private void gvstaffdetailsP_MouseClick(object sender, MouseEventArgs e)
        {

            txtemp.Text = gvstaffdetailsP.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = gvstaffdetailsP.SelectedRows[0].Cells[1].Value.ToString();
            txtnic.Text = gvstaffdetailsP.SelectedRows[0].Cells[2].Value.ToString();
            txttel.Text = gvstaffdetailsP.SelectedRows[0].Cells[3].Value.ToString();
            txtaddress.Text = gvstaffdetailsP.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//this linkLable displays "Next"
        {
            frmstaffdetails_O frm = new frmstaffdetails_O();
            frm.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           try{
                SEARCH();
                con.Open();
                string query_togrid = "SELECT * FROM staffdetailsP WHERE EmpID='" + txtsearch.Text + "'";
                cmd = new SqlCommand(query_togrid, con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    txtempid.Text = reader["EmpID"].ToString();
                    txtname.Text = reader["Name"].ToString();
                    txtnic.Text = reader["NIC"].ToString();
                    txttel.Text = reader["Tel"].ToString();
                    txtaddress.Text = reader["Address"].ToString();
                    txtemp.Text = reader["EmpNo"].ToString();
                    string GENDER = reader["Gender"].ToString();
                    if (GENDER == "F")
                    {
                        radiofemale.Checked = true;
                        radiomale.Checked = false;
                    }
                    else if (GENDER == "M")
                    {
                        radiofemale.Checked = true;
                        radiomale.Checked = false;
                    }
                    reader.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please check the EmpID again.The EmpID migth be lost or the EmpID is incorrected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
                   
        }
        private void CLEAR()
        {
            txtempid.Clear();
            txtname.Clear();
            txtnic.Clear();
            txttel.Clear();
            txtaddress.Clear();
            txtemp.Clear();
            radiofemale.Checked = false;
            radiomale.Checked = false;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            CLEAR();
        }

        private void gvstaffdetailsP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
