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
    public partial class Registration : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Registration()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {


            Registration_Detail f1 = new Registration_Detail();
            f1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }

        private void BUT1New_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            password.Text = "";
            name.Text = "";
            contact_no.Text = "";
           
        }

        private void contact_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUT2Save_Click(object sender, EventArgs e)
        {
             try
            { 
                con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Registration values('" + textBox1.Text + " ', ' " + password.Text + " ',' " + name.Text + " ',' " + contact_no.Text + " ')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record has been added");
            con.Close();
                textBox1.Text = "";
                password.Text = "";
                name.Text = "";
                contact_no.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }

        }

        private void BUT3Update_Click(object sender, EventArgs e)
        {
            /*con.Open();
            OleDbCommand command = new OleDbCommand("Update Registration set Password='"+password.Text+"' where Username='"+textBox1.Text+"'",con);
            command.ExecuteNonQuery();
            MessageBox.Show("One record has been updated ");
            con.Close();*/
           

              /*  con.Open();
                string Password = password.Text;
                string Username = textBox1.Text;
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText="UPDATE Registration SET Password=" +Password+ " WHERE Username="+Username+"" ;
            if (con.State == ConnectionState.Open)
            {
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("One record has been updated ");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Error ");
            }*/

                
           /* try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "Update Registration set Password='" + password.Text + "' where Username= '" + textBox1.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("One record has been updated ");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }*/
        }

        private void BUT4Delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                string query = "delete from Registration where Username =  '" + textBox1.Text + " '";
                com1.CommandText = query;
                com1.ExecuteNonQuery();
                MessageBox.Show("One record has been deleted ");
                con.Close();
                textBox1.Text = "";
                password.Text = "";
                name.Text = "";
                contact_no.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       /* private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "Update Registration set Password='" + password.Text + "' where Username= '" + textBox1.Text + "'";
            MessageBox.Show(query);
            command.CommandText = query;

            command.ExecuteNonQuery();
            MessageBox.Show("One record has been updated ");
            con.Close();
        }*/
    }
}
