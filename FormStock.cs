using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace SEproject
{
    public partial class FormStock : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormStock()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStockDetail1 f1 = new FormStockDetail1();
            f1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductRecord f1 = new FormProductRecord();
            f1.Show();
        }

        private void B2Save_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Stock values('" + txtID.Text + " ', ' " + txtPcode.Text + " ',' " + txtPname.Text + " ',' " + txtCategory.Text + " ',' " + txtWeight.Text + "' ,'"+dateTimePicker1.Value+"',' " + textBox2.Text + " ',' " + textBox3.Text + " ',' " + textBox4.Text + " ')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record has been added");
            con.Close();
            txtID.Text = "";
            txtPcode.Text = "";
            txtPname.Text = "";
            txtCategory.Text = "";
            txtWeight.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void B4Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Stock where StockID ='" + txtID.Text + " '";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" record deleted successfully");
            con.Close();
            txtID.Text = "";
            txtPcode.Text = "";
            txtPname.Text = "";
            txtCategory.Text = "";
            txtWeight.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void B1New_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPcode.Text = "";
            txtPname.Text = "";
            txtCategory.Text = "";
            txtWeight.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void B3Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "Update Stock set Cartons='" + textBox2.Text + "' where StockID= '" + txtID.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("One record has been updated ");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormStockDetail1 f1 = new FormStockDetail1();
            f1.Show();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "select StockID,ProductCode,ProductName,Category,Weight,StockDate,Cartons,Packets,TotalPackets from Stock";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPcode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCategory.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtWeight.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Product_Details_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
