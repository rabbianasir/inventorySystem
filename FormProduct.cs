﻿using System;
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
    public partial class FormProduct : Form
    {
        OleDbConnection con = new OleDbConnection();
        public FormProduct()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\inventorysystem (1).accdb";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FormProductRecord2 f1 = new FormProductRecord2();
            f1.Show();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            textPROID.Text = "";
            name.Text = "";
            category.Text = "";
            weight.Text = "";
            price.Text = "";
          
        }

        private void BSave_Click(object sender, EventArgs e)
        {
           
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Product where ProductCode ='" + textPROID.Text + " '";
            cmd.ExecuteNonQuery();
            MessageBox.Show(" record deleted successfully");
            con.Close();
            textPROID.Text = "";
            name.Text = "";
            category.Text = "";
            weight.Text = "";
            price.Text = "";
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "Update Product set Price='" + price.Text + "' where ProductCode= '" + textPROID.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("One record has been updated ");
                con.Close();
                textPROID.Text = "";
                name.Text = "";
                category.Text = "";
                weight.Text = "";
                price.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Product values('" + textPROID.Text + " ', ' " + name.Text + " ',' " + category.Text + " ',' " + weight.Text + " ','" + price.Text + " ' )";
                cmd.ExecuteNonQuery();

                MessageBox.Show("One record has been added");
                con.Close();
                textPROID.Text = "";
                name.Text = "";
                category.Text = "";
                weight.Text = "";
                price.Text = "";
            }
            catch (Exception ex)
            { MessageBox.Show("Error " + ex); }

        }
    }
}
