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
    public partial class Form_Distributor : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form_Distributor()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FormCustomerRecord3 f1 = new FormCustomerRecord3();
            f1.Show();
        }

        private void Form_Distributor_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Customer values('" + textName.Text + " ', ' " + textaddress.Text + " ',' " + textlandmark.Text + " ',' " + textcity.Text + " ','" + comboboxstate.Text + " ','" + textzipcode.Text + " ','" + textdistributor_id.Text + " ','" + textphone.Text + " ','" + textemail.Text + " ','" + textmobile_no.Text + " ','" + textfax_no.Text + " ','" + textnotes.Text + " ')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("One record has been added");
                con.Close();
                textName.Text = "";
                textaddress.Text = "";
                textlandmark.Text = "";
                textcity.Text = "";
                comboboxstate.Text = "";
                textzipcode.Text = "";
                textdistributor_id.Text = "";
                textphone.Text = "";
                textemail.Text = "";
                textmobile_no.Text = "";
                textfax_no.Text = "";
                textnotes.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }

        }

        private void NewB_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textaddress.Text = "";
            textlandmark.Text = "";
            textcity.Text = "";
            comboboxstate.Text = "";
            textzipcode.Text = "";
            textdistributor_id.Text = "";
            textphone.Text = "";
            textemail.Text = "";
            textmobile_no.Text = "";
            textfax_no.Text = "";
            textnotes.Text = "";

        }

        private void textzipcode2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                string query = "delete from Customer where CustomerNo =  '" + textdistributor_id.Text + " '";
                com1.CommandText = query;
                com1.ExecuteNonQuery();
                MessageBox.Show("One record has been deleted ");
                con.Close();
                textName.Text = "";
                textaddress.Text = "";
                textlandmark.Text = "";
                textcity.Text = "";
                comboboxstate.Text = "";
                textzipcode.Text = "";
                textdistributor_id.Text = "";
                textphone.Text = "";
                textemail.Text = "";
                textmobile_no.Text = "";
                textfax_no.Text = "";
                textnotes.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
            
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "Update Customer set Phone='" + textphone.Text + "' where CustomerNo= '" + textdistributor_id.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("One record has been updated ");
                con.Close();
                textName.Text = "";
                textaddress.Text = "";
                textlandmark.Text = "";
                textcity.Text = "";
                comboboxstate.Text = "";
                textzipcode.Text = "";
                textdistributor_id.Text = "";
                textphone.Text = "";
                textemail.Text = "";
                textmobile_no.Text = "";
                textfax_no.Text = "";
                textnotes.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }
    }
}
