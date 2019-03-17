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
    public partial class Registration_Detail : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Registration_Detail()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }



        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {




        }

        private void Registration_Detail_Load(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string query = "select Username,Password,Name,ContactNo from Registration";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

            /*OleDbDataAdapter adap = new OleDbDataAdapter("select * from Registration ", con);
        DataSet d1 = new DataSet("Registration");
        con.Open();
        adap.Fill(d1, "Registration");
        dataGrid1.DataSource = d1;
        con.Close();*/
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Registration myForm = new Registration();

            myForm.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.password.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          myForm.contact_no.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            myForm.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}