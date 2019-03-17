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


namespace SEproject
{
    public partial class FormProductRecord2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormProductRecord2()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "select ProductName , Weight , Category from Product";
            com.CommandText = query;
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["ProductName"].ToString());
                comboBox2.Items.Add(reader["Weight"].ToString());
                comboBox3.Items.Add(reader["Category"].ToString());

            }
            con.Close();

        }

        

        private void GetData_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "select ProductCode,ProductName,Category,Weight,Price from Product";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

      

        private void FormProductRecord2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormProduct myForm = new FormProduct();

            myForm.textPROID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.category.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.weight.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

            myForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormProduct myForm2 = new FormProduct();

            myForm2.textPROID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            myForm2.name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            myForm2.category.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            myForm2.weight.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            myForm2.price.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();


            myForm2.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormProduct myForm1 = new FormProduct();

            myForm1.textPROID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            myForm1.name.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            myForm1.category.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            myForm1.weight.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            myForm1.price.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();


            myForm1.ShowDialog();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormProduct myForm = new FormProduct();

            myForm.textPROID.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            myForm.name.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            myForm.category.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            myForm.weight.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            myForm.price.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();


            myForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            OleDbCommand Cmd = new OleDbCommand();

            Cmd.Connection = con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Select * from ProductSold where ProductName =  '" + comboBox1.SelectedItem + " '";

            OleDbDataAdapter cmdDataAdap = new OleDbDataAdapter(Cmd);

            DataTable dtRecord = new DataTable();
            cmdDataAdap.Fill(dtRecord);
            dataGridView2.DataSource = dtRecord;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand Cmd = new OleDbCommand();

            Cmd.Connection = con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Select * from ProductSold where Weight =  '" + comboBox2.SelectedItem + " '";

            OleDbDataAdapter cmdDataAdap = new OleDbDataAdapter(Cmd);

            DataTable dtRecord = new DataTable();
            cmdDataAdap.Fill(dtRecord);
            dataGridView3.DataSource = dtRecord;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand Cmd = new OleDbCommand();

            Cmd.Connection = con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Select * from ProductSold where Category =  '" + comboBox3.SelectedItem + " '";

            OleDbDataAdapter cmdDataAdap = new OleDbDataAdapter(Cmd);

            DataTable dtRecord = new DataTable();
            cmdDataAdap.Fill(dtRecord);
            dataGridView4.DataSource = dtRecord;
        }
    }
}
