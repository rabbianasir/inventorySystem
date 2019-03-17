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
    public partial class FormCustomerRecord3 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormCustomerRecord3()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

        }

        private void FormCustomerRecord3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "select BillName,BillAddress,BillLandmark,BillCity,BillState,BillZipcode,CustomerNo,Phone,Email,MobileNo,FaxNo,Notes from Customer";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();
            
            /* OleDbDataAdapter adap = new OleDbDataAdapter("select * from Customer ", con);
            DataSet d1 = new DataSet("Customer");
            con.Open();
            adap.Fill(d1, "Customer");
            dataGridView1.DataSource = d1;
            con.Close();*/
        }

       

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            Form_Distributor myForm = new Form_Distributor();

            myForm.textName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.textaddress.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.textlandmark.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.textcity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.comboboxstate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myForm.textzipcode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myForm.textdistributor_id.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            myForm.textphone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            myForm.textemail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            myForm.textmobile_no.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            myForm.textfax_no.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            myForm.textnotes.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();


            myForm.ShowDialog();
        }
    }
}
