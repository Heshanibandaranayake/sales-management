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
    public partial class frmstoredetails : Form
    {
        public frmstoredetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter myadp = new SqlDataAdapter();
        int style_ID;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)//This picturebox displays "Back" option
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//This linkLable displays "Next" option
        {
            frmstore frm = new frmstore();
            frm.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con.Open();
                cmd = new SqlCommand("SELECT(MAX(StyleID)+1) AS StyleID FROM Bettans_store", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader["StyleID"] is DBNull)
                {
                    style_ID = 1;
                }
                else
                {
                    style_ID = Convert.ToInt16(reader["StyleID"]);
                }
                reader.Close();

               
                string style = txtstyle.Text;
                int size = int.Parse(txtsize.Text);
                int price = int.Parse(txtprice.Text);
                string serialno = txtserialname.Text;
                int qty = int.Parse(txtquantity.Text);
                

                string query_insert = "INSERT INTO Bettans_store (StyleID,Style,Size,Price,Quantity,SerialNo) values ('" + style_ID + "','" + style + "','" + size + "','" + price+"','"+ qty + "','" + serialno + "')";
                cmd = new SqlCommand(query_insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch 
            {
                MessageBox.Show("Error while saving. Check your entired data again.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }

       /* private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int styleid = int.Parse(txtstyleid.Text);
                string style = txtstyle.Text;
                int price = int.Parse(txtprice.Text);
                int size = int.Parse(txtsize.Text);
                int quantity = int.Parse(txtquantity.Text);
                int serialno = int.Parse(txtserialname.Text);
                con.Open();
                string query_update = "UPDATE Bettans_store SET Style='" + style + "',Size='" + size + "',Price='" + price + "',Quantity='"+txtquantity + "',SerialNo='" + serialno + "' WHERE StyleID='" + styleid + "'";
                cmd = new SqlCommand(query_update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating"+ex, "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }*/
        public void SHOWALLGV()
        {
            con.Open();
            string query_togrid = "SELECT * FROM Bettans_store";
            myadp = new SqlDataAdapter(query_togrid, con);
            DataTable mytable = new DataTable();
            myadp.Fill(mytable);
            gvstoredetails.DataSource = mytable;

            gvstoredetails.Columns[0].Width = 100;
            gvstoredetails.Columns[1].Width = 100;
            gvstoredetails.Columns[2].Width = 100;
            gvstoredetails.Columns[3].Width = 100;
            gvstoredetails.Columns[4].Width = 100;
            gvstoredetails.Columns[5].Width = 100;
            
            con.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
        }
        private void SEARCH()
        {
            con.Open();
            string query_togrid = "SELECT * FROM Bettans_store WHERE StyleID='" + txtsearch.Text + "'";
            myadp = new SqlDataAdapter(query_togrid, con);
            DataTable table = new DataTable();
            myadp.Fill(table);
            gvstoredetails.DataSource = table;
            con.Close();
        }


        private void gvstoredetails_MouseClick(object sender, MouseEventArgs e)
        {
            txtstyleid.Text = gvstoredetails.SelectedRows[0].Cells[0].Value.ToString();
            txtstyle.Text = gvstoredetails.SelectedRows[0].Cells[1].Value.ToString();
            txtsize.Text = gvstoredetails.SelectedRows[0].Cells[2].Value.ToString();
            txtprice.Text = gvstoredetails.SelectedRows[0].Cells[3].Value.ToString();
            txtquantity.Text = gvstoredetails.SelectedRows[0].Cells[4].Value.ToString();
            txtserialname.Text = gvstoredetails.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SEARCH();
            con.Open();
            string query_togrid = "SELECT * FROM Bettans_store WHERE StyleID='" + txtsearch.Text + "'";
            cmd = new SqlCommand(query_togrid, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                reader.Read();
                txtstyleid.Text = reader["StyleID"].ToString();
                txtstyle.Text = reader["Style"].ToString();
                txtsize.Text = reader["size"].ToString();
                txtprice.Text = reader["Price"].ToString();
                txtquantity.Text = reader["Quantity"].ToString(); 
                txtserialname.Text = reader["SerialNo"].ToString();
                reader.Close();
            }
            con.Close();
        }
        private void CLEAR()
        {
            txtstyleid.Clear();
            txtstyle.Clear();
            txtsize.Clear();
            txtprice.Clear();
            txtserialname.Clear();
            txtquantity.Clear();
        }

        private void frmstoredetails_Load(object sender, EventArgs e)
        {
           
            con.Open();
            cmd = new SqlCommand("SELECT(MAX(StyleID)+1) AS StyleID FROM Bettans_store", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["StyleID"] is DBNull)
            {
                style_ID = 1;
            }
            else
            {
                style_ID = Convert.ToInt16(reader["StyleID"]);
            }
            if (reader.HasRows == true)
            {
                
                txtstyleid.Text = reader["StyleID"].ToString();
                reader.Close();
            }
            
            con.Close();
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            SHOWALLGV();
            CLEAR();
            con.Open();
            cmd = new SqlCommand("SELECT(MAX(StyleID)+1) AS StyleID FROM Bettans_store ", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["StyleID"] is DBNull)
            {
                style_ID = 1;
            }
            else
            {
                style_ID = Convert.ToInt16(reader["StyleID"]);
            }
            if (reader.HasRows == true)
            {

                txtstyleid.Text = reader["StyleID"].ToString();
                reader.Close();
            }

            con.Close();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                int styleid = int.Parse(txtstyleid.Text);
                con.Open();
                string query_delete = "DELETE FROM Bettans_store WHERE StyleID='" + styleid + "'";
                cmd = new SqlCommand(query_delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error while deleting", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                int styleid = int.Parse(txtstyleid.Text);
                string style = txtstyle.Text;
                int price = int.Parse(txtprice.Text);
                int size = int.Parse(txtsize.Text);
                string serialno = txtserialname.Text;
                int qty = int.Parse(txtquantity.Text);
                con.Open();
                string query_update = "UPDATE Bettans_store SET Style='" + style + "',Size='" + size + "',Price='" + price + "',Quantity='"+ qty + "',SerialNo='" + serialno + "' WHERE StyleID='" + styleid + "'";
                cmd = new SqlCommand(query_update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");

            }
            catch 
            {
                MessageBox.Show("Error while updating.Check your entired data again.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)// "Clear" is text of this button2
        {
            CLEAR();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
