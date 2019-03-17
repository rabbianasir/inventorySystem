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
    public partial class FormOrderRecord1 : Form
    {

        OleDbConnection con = new OleDbConnection();
        public FormOrderRecord1()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query = "select OrderNo from OrderInfo";
            com.CommandText = query;
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                comOrder.Items.Add(reader["OrderNo"].ToString());
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void FormOrderRecord1_Load(object sender, EventArgs e)
        {

        }

        private void comOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand Cmd = new OleDbCommand();

            Cmd.Connection = con;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "Select OrderNo,OrderDate,OrderStatus,CustomerNo,CustomerName from Orderinfo where OrderNo  =  '" + comOrder.SelectedItem + " '";

            OleDbDataAdapter cmdDataAdap = new OleDbDataAdapter(Cmd);

            DataTable dtRecord = new DataTable();
            cmdDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormOrder myForm = new FormOrder();

            myForm.textORDERNO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.comboSTATUS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.textDID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.textDNAME.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
  
            myForm.ShowDialog();
        }
    }
}
