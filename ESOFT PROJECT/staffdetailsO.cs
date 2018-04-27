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
    public partial class frmstaffdetails_O : Form
    {
        public frmstaffdetails_O()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();

        private void frmstaffdetails_O_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)//This picturebox displays the "Back" icon
        {
            frmStaffdetals_personal frm = new frmStaffdetals_personal();
            frm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtothours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                int OThrs;
                int OTrate, OTamount, NETsalary, BASICsalary;
                BASICsalary = int.Parse(txtbasicsalary.Text);
                OTrate = int.Parse(txtotrate.Text);
                OThrs = int.Parse(txtothours.Text);
                //To find out OT Amount
                OTamount = OThrs * OTrate;
                txtotamount.Text = OTamount.ToString();
                //To Find out Net Salary
                NETsalary = BASICsalary + OTamount;
                txtnetsalary.Text = NETsalary.ToString();
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Invalid data.Check your entired data and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();

                int empno = int.Parse(txtempno.Text);
                int basicsal = int.Parse(txtbasicsalary.Text);
                int year = int.Parse(txtyear.Text);
                string month = txtmonth.Text;
                int ot_hours = int.Parse(txtothours.Text);
                int ot_rate = int.Parse(txtotrate.Text);
                int ot_amount = int.Parse(txtotamount.Text);
                int netsal = int.Parse(txtnetsalary.Text);
                string EMPNO = txtempno.Text;
                string query_insert = "INSERT INTO STAFFDETAILS_OFFICIAL(EmpNo,BasicSalary,Year,Month,OT_Hours,OT_Rate,OT_Amount,NetSalary) values ('" + empno + "','" + basicsal + "','" + year + "','" + month + "','" + ot_hours + "','" + ot_rate + "','" + ot_amount + "','" + netsal + "')";
                cmd = new SqlCommand(query_insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtdelete_Click(object sender, EventArgs e)
        {
            try
            {
                int empno = int.Parse(txtempno.Text);
                con.Open();
                string query_delete = "DELETE FROM STAFFDETAILS_OFFICIAL WHERE EmpNo='" + empno + "'";
                cmd = new SqlCommand(query_delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {
                MessageBox.Show("Error while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
        public void SHOWALLGRV()
        {
            con.Open();
            string query_togrid = "SELECT * FROM STAFFDETAILS_OFFICIAL ";
            adp = new SqlDataAdapter(query_togrid, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            gvstaffdetails_Official.DataSource = table;
            con.Close();

        }


        private void button1_Click(object sender, EventArgs e)//"Refresh" is Text of button1
        {
            SHOWALLGRV();
            // CLEAR();    
        }
        private void SEARCH()
        {
            con.Open();
            string query_togrid = "SELECT * FROM STAFFDETAILS_OFFICIAL WHERE EmpNo='" + txtsearch_empno.Text + "'";
            adp = new SqlDataAdapter(query_togrid, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            gvstaffdetails_Official.DataSource = table;
            con.Close();
        }

        private void txtsearch_postid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_year_month_TextChanged(object sender, EventArgs e)
        {



        }

        private void gvstaffdetails_Official_MouseClick(object sender, MouseEventArgs e)
        {
            txtempno.Text = gvstaffdetails_Official.SelectedRows[0].Cells[0].Value.ToString();
            txtbasicsalary.Text = gvstaffdetails_Official.SelectedRows[0].Cells[1].Value.ToString();
            txtyear.Text = gvstaffdetails_Official.SelectedRows[0].Cells[2].Value.ToString();
            txtmonth.Text = gvstaffdetails_Official.SelectedRows[0].Cells[3].Value.ToString();
            txtothours.Text = gvstaffdetails_Official.SelectedRows[0].Cells[4].Value.ToString();
            txtotrate.Text = gvstaffdetails_Official.SelectedRows[0].Cells[5].Value.ToString();
            txtotrate.Text = gvstaffdetails_Official.SelectedRows[0].Cells[6].Value.ToString();
            txtnetsalary.Text = gvstaffdetails_Official.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {

                int empno = int.Parse(txtempno.Text);
                int basicsal = int.Parse(txtbasicsalary.Text);
                int year = int.Parse(txtyear.Text);
                string month = txtmonth.Text;
                int othours = int.Parse(txtothours.Text);
                int otrate = int.Parse(txtotrate.Text);
                int otamount = int.Parse(txtotamount.Text);
                int netsalary = int.Parse(txtnetsalary.Text);
                con.Open();
                string query_update = "UPDATE STAFFDETAILS_OFFICIAL SET BasicSalary='" + basicsal + "' ,Year='" + year + "',Month='" + month + "',OT_Hours='" + othours + "',OT_Rate='" + otrate + "',OT_Amount='" + otamount + "',NetSalary='" + netsalary + "'WHERE EmpNo='" + empno + "'";
                cmd = new SqlCommand(query_update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Update");
            }
            catch
            {
                MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SEARCH();

            con.Open();

            string query_togrid = "SELECT * FROM STAFFDETAILS_OFFICIAL WHERE EmpNo='" + txtsearch_empno.Text + "'";
            cmd = new SqlCommand(query_togrid, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                reader.Read();
                txtempno.Text = reader["EmpNo"].ToString();
                txtbasicsalary.Text = reader["BasicSalary"].ToString();
                txtyear.Text = reader["Year"].ToString();
                txtmonth.Text = reader["Month"].ToString();
                txtothours.Text = reader["OT_Hours"].ToString();
                txtotrate.Text = reader["OT_Rate"].ToString();
                txtotamount.Text = reader["OT_Amount"].ToString();
                txtnetsalary.Text = reader["NetSalary"].ToString();
                reader.Close();

            }


            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            CLEAR();

        }
        /* catch
         {
             MessageBox.Show("this data is not in the database");
         }
         */

        private void CLEAR()
        {
            txtempno.Clear();
            txtbasicsalary.Clear();
            txtyear.Clear();
            txtmonth.Clear();
            txtothours.Clear();
            txtotrate.Clear();
            txtotamount.Clear();
            txtnetsalary.Clear();

        }

        /* private void btnclear_Click(object sender, EventArgs e)
         {
             CLEAR();
         }*/
    }
}


