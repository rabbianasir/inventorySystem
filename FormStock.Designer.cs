namespace SEproject
{
    partial class FormStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Product_Details = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.B4Delete = new System.Windows.Forms.Button();
            this.B1New = new System.Windows.Forms.Button();
            this.B2Save = new System.Windows.Forms.Button();
            this.B3Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Details.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Details
            // 
            this.Product_Details.BackColor = System.Drawing.Color.DarkCyan;
            this.Product_Details.Controls.Add(this.txtWeight);
            this.Product_Details.Controls.Add(this.txtCategory);
            this.Product_Details.Controls.Add(this.textBox4);
            this.Product_Details.Controls.Add(this.textBox3);
            this.Product_Details.Controls.Add(this.textBox2);
            this.Product_Details.Controls.Add(this.label9);
            this.Product_Details.Controls.Add(this.dateTimePicker1);
            this.Product_Details.Controls.Add(this.label8);
            this.Product_Details.Controls.Add(this.label7);
            this.Product_Details.Controls.Add(this.Date);
            this.Product_Details.Controls.Add(this.label5);
            this.Product_Details.Controls.Add(this.label4);
            this.Product_Details.Controls.Add(this.label3);
            this.Product_Details.Controls.Add(this.label2);
            this.Product_Details.Controls.Add(this.label1);
            this.Product_Details.Controls.Add(this.txtPname);
            this.Product_Details.Controls.Add(this.txtPcode);
            this.Product_Details.Controls.Add(this.txtID);
            this.Product_Details.Location = new System.Drawing.Point(25, 52);
            this.Product_Details.Name = "Product_Details";
            this.Product_Details.Size = new System.Drawing.Size(465, 498);
            this.Product_Details.TabIndex = 19;
            this.Product_Details.TabStop = false;
            this.Product_Details.Text = "Stock Details";
            this.Product_Details.Enter += new System.EventHandler(this.Product_Details_Enter);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(174, 209);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(193, 27);
            this.txtWeight.TabIndex = 52;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(174, 169);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(193, 27);
            this.txtCategory.TabIndex = 51;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 370);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 27);
            this.textBox4.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 27);
            this.textBox3.TabIndex = 49;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 27);
            this.textBox2.TabIndex = 48;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Total Packets";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 27);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Packets (Per Carton)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cartons";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(29, 253);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(40, 19);
            this.Date.TabIndex = 42;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Weight(Per Qty)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Product Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Stock ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(174, 124);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(271, 27);
            this.txtPname.TabIndex = 34;
            this.txtPname.TextChanged += new System.EventHandler(this.txtPname_TextChanged);
            // 
            // txtPcode
            // 
            this.txtPcode.Location = new System.Drawing.Point(174, 83);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(193, 27);
            this.txtPcode.TabIndex = 33;
            this.txtPcode.TextChanged += new System.EventHandler(this.txtPcode_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 27);
            this.txtID.TabIndex = 32;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.B4Delete);
            this.panel3.Controls.Add(this.B1New);
            this.panel3.Controls.Add(this.B2Save);
            this.panel3.Controls.Add(this.B3Update);
            this.panel3.Location = new System.Drawing.Point(199, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 71);
            this.panel3.TabIndex = 42;
            // 
            // B4Delete
            // 
            this.B4Delete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.B4Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B4Delete.Location = new System.Drawing.Point(489, 14);
            this.B4Delete.Name = "B4Delete";
            this.B4Delete.Size = new System.Drawing.Size(105, 39);
            this.B4Delete.TabIndex = 33;
            this.B4Delete.Text = "Delete";
            this.B4Delete.UseVisualStyleBackColor = false;
            this.B4Delete.Click += new System.EventHandler(this.B4Delete_Click);
            // 
            // B1New
            // 
            this.B1New.BackColor = System.Drawing.Color.DarkSlateGray;
            this.B1New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B1New.Location = new System.Drawing.Point(62, 14);
            this.B1New.Name = "B1New";
            this.B1New.Size = new System.Drawing.Size(105, 39);
            this.B1New.TabIndex = 30;
            this.B1New.Text = "New";
            this.B1New.UseVisualStyleBackColor = false;
            this.B1New.Click += new System.EventHandler(this.B1New_Click);
            // 
            // B2Save
            // 
            this.B2Save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.B2Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B2Save.Location = new System.Drawing.Point(199, 14);
            this.B2Save.Name = "B2Save";
            this.B2Save.Size = new System.Drawing.Size(105, 39);
            this.B2Save.TabIndex = 31;
            this.B2Save.Text = "Save";
            this.B2Save.UseVisualStyleBackColor = false;
            this.B2Save.Click += new System.EventHandler(this.B2Save_Click);
            // 
            // B3Update
            // 
            this.B3Update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.B3Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B3Update.Location = new System.Drawing.Point(346, 14);
            this.B3Update.Name = "B3Update";
            this.B3Update.Size = new System.Drawing.Size(105, 39);
            this.B3Update.TabIndex = 32;
            this.B3Update.Text = "Update";
            this.B3Update.UseVisualStyleBackColor = false;
            this.B3Update.Click += new System.EventHandler(this.B3Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 26);
            this.label6.TabIndex = 51;
            this.label6.Text = "Stock Entry";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkCyan;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(706, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 26);
            this.label10.TabIndex = 52;
            this.label10.Text = "Current Stock";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEproject.Properties.Resources.images__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 633);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(524, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 498);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1080, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Product_Details);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.Product_Details.ResumeLayout(false);
            this.Product_Details.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button B4Delete;
        private System.Windows.Forms.Button B3Update;
        private System.Windows.Forms.Button B2Save;
        private System.Windows.Forms.Button B1New;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox Product_Details;
        public System.Windows.Forms.TextBox txtPname;
        public System.Windows.Forms.TextBox txtPcode;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtWeight;
        public System.Windows.Forms.TextBox txtCategory;
    }
}