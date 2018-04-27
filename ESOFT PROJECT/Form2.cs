using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//this class the .Netframework data provider for SQL Server

namespace ESOFT_PROJECT
{
    public partial class frmstaffdetails : Form
    {
        
        public frmstaffdetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\PROJECT\ESOFT PROJECT\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmstaffdetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//link to Staff details(official)
        {
            frmstaffdetails_O frm = new frmstaffdetails_O();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmloginpage frm = new frmloginpage();
            frm.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("INSERT INTO staffdetailsP (EmpNo,Name,NIC,Tel(primary),Tel(alternative),Address,Gender) values ('" + txtempno.Text+ "','" +txtname.Text+"','"+txtnic.Text+"','"+txttel_p.Text+"','"+txttel_a.Text+"','"+txtaddress.Text+","+comboBox1.Text+"')", con);
                adp.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("success", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving" + ex);
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
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("DELETE FROM staffdetailsP WHERE EmpNo='" + txtempno.Text + "'", con);
                adp.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("UPDATE staffdetailsP SET Name='" +txtname.Text+"',NIC='"+txtnic.Text+"',Tel(primary)='"+txttel_p.Text+"',Tel(alternative)='"+txttel_a.Text+"',Address='"+txtaddress.Text+"',Gender='"+comboBox1.Text+"'WHERE EmpNo='" + txtempno.Text + "'", con);
                adp.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Success");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating", "Update" + ex);
            }
            finally
            {
                con.Close();
            }
        }
       

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM staffdetailsP", con);
            DataTable table = new DataTable();
            adp.Fill(table);
            gvstaff_details_personal.DataSource = table;
            con.Close();


        }

      

        private void txtstaffdetails_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT EmpNo,Name,NIC,Tel(primary),Tel(alternative),Address,Gender FROM staffdetailsP WHERE EmpNo LIKE '" + txtstaffdetails.Text + "%'", con);
            DataTable table = new DataTable();
            sda.Fill(table);
            gvstaff_details_personal.DataSource = table;
        }

        private void gvstaff_details_personal_MouseClick(object sender, MouseEventArgs e)
        {
            txtempno.Text = gvstaff_details_personal.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = gvstaff_details_personal.SelectedRows[0].Cells[1].Value.ToString();
            txtnic.Text = gvstaff_details_personal.SelectedRows[0].Cells[2].Value.ToString();
            txttel_p.Text = gvstaff_details_personal.SelectedRows[0].Cells[3].Value.ToString();
            txttel_a.Text = gvstaff_details_personal.SelectedRows[0].Cells[4].Value.ToString();
            txtaddress.Text = gvstaff_details_personal.SelectedRows[0].Cells[5].Value.ToString();
            comboBox1.Text = gvstaff_details_personal.SelectedRows[0].Cells[6].Value.ToString();


        }
        
       



    }
}



            

            
    
    
    
    
        



        


            
        
                    





        
    

