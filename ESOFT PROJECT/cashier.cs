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
    public partial class frmcashier : Form
    {
        public frmcashier()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\USER\Desktop\SALAES MANAGEMENT SYSTEM\New Esoft Project\ESOFT PROJECT\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        int X;
        int Y;
        
        private void txtchange_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtserialno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {

                
                int price;
                int qty;
                int amount;
                price = int.Parse(txtprice.Text);
                qty = int.Parse(txtQty.Text);
                amount = qty * price;
                txtamount.Text = amount.ToString();
                int cash = int.Parse(txtcash.Text); 
                int change;
                change = cash - amount;
                txtchange.Text = change.ToString();
            
                
            }
            catch
            {
                MessageBox.Show("You must fill every textboxes that are enabled");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("  " + "Bettans Group of Companies(PVT) Ltd");
                listBox1.Items.Add("      " +   "Yaninuvara Veediya");
                listBox1.Items.Add("              " + "Kandy");
                listBox1.Items.Add("           " + "Tel:0812384556");
                listBox1.Items.Add("   " +    "Email:info@bettans.lk");
                listBox1.Items.Add("  "+"------------------------------------------");
                listBox1.Items.Add("    " + " Style" + "       " + "Price" + "         " + "Qty" + "     " + "Amount");
                listBox1.Items.Add("  " + txtstyle.Text + "  Rs." + txtprice.Text+".00" + "     " + txtQty.Text + "   Rs." + txtamount.Text+".00");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("");
                listBox1.Items.Add("  "+"--------------------------------------------");
                listBox1.Items.Add("      CASH  :      Rs." + txtcash.Text+".00");
                listBox1.Items.Add("      CHANGE:      Rs." + txtchange.Text+".00");
                listBox1.Items.Add("  " + "--------------------------------------------");
                listBox1.Items.Add("               " + " THANK YOU");
                listBox1.Items.Add("               " + " COME AGAIN");
                listBox1.Items.Add("      " + " Software by Esoft-DITEC-Batch 59");
            }
            catch
            {
                MessageBox.Show("you must entire every input data");
            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query_update = "SELECT Quantity FROM Bettans_store WHERE StyleID='" + txtstyleid.Text + "' ";
                //string query_up = "UPDATE Bettans_store SET Quantity";
                cmd = new SqlCommand(query_update, con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    //reader.Read();
                    //  X = reader["Quantity"].ToString();
                    X = Convert.ToInt16(reader["Quantity"]);

                    Y = X - Convert.ToInt16(txtQty.Text);
                    /*string QUERY_UPDATE = "UPDATE Bettans_store SET Quantity='" + Y + "'WHERE StyleID='" + txtstyleid.Text + "'";
                    cmd = new SqlCommand(QUERY_UPDATE, con);
                    cmd.ExecuteNonQuery();*/

                }
                reader.Close();


                string QUERY_UPDATE = "UPDATE Bettans_store SET Quantity='" + Y + "'WHERE StyleID='" + txtstyleid.Text + "'";
                cmd = new SqlCommand(QUERY_UPDATE, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Invalid data. Chech your entied data again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
            
            
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(listBox1.Text, new Font("Arial", 18, FontStyle.Italic), Brushes.Black, 150, 125);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtcolour_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//This pictureBox displays "Back" option
        {
            frmuser_selection frm = new frmuser_selection();
            frm.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstyleid.Clear();
            txtstyle.Clear();
            txtprice.Clear();
            txtQty.Clear();
            txtamount.Clear();
            txtcash.Clear();
            txtchange.Clear();
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtserialno_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void gvstore_MouseClick(object sender, MouseEventArgs e)
        {
            
            txtstyle.Text = gvstore.SelectedRows[0].Cells[1].Value.ToString();
            txtprice.Text = gvstore.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void frmcashier_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtstyleid_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT StyleID,Style,Price,Quantity FROM Bettans_store  WHERE StyleID LIKE '" + txtstyleid.Text + "%'", con);
            DataTable mydata = new DataTable();
            sda.Fill(mydata);
            gvstore.DataSource = mydata;

        }

        private void gvstore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
