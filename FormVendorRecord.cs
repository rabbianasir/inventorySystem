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
    public partial class FormVendorRecord : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormVendorRecord()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "select VendorID,VName,Address,Landmark,City,State,Zipcode,Phone,Email,MobileNo,FaxNo,Notes from Vendor";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FormVendor myForm = new FormVendor();

            myForm.vendorid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.landmark.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.city.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myForm.state.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myForm.zipcode.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            myForm.phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            myForm.email.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            myForm.mobile_no.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            myForm.fax_no.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            myForm.notes.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();


            myForm.ShowDialog();
        }
    }
}
