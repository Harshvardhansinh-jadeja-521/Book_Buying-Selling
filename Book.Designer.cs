﻿
namespace Project_brosale
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtbookdes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbookcond = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbookcat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picimg = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookauthor = new System.Windows.Forms.TextBox();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtbookdes);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtbookcond);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtbookcat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.picimg);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtbookauthor);
            this.panel2.Controls.Add(this.txtbooktitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(279, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 770);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(268, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 35);
            this.button4.TabIndex = 32;
            this.button4.Text = "Upload";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbookdes
            // 
            this.txtbookdes.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookdes.Location = new System.Drawing.Point(659, 260);
            this.txtbookdes.Name = "txtbookdes";
            this.txtbookdes.Size = new System.Drawing.Size(197, 30);
            this.txtbookdes.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(654, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 27);
            this.label11.TabIndex = 30;
            this.label11.Text = "Description";
            // 
            // txtbookcond
            // 
            this.txtbookcond.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookcond.Location = new System.Drawing.Point(616, 160);
            this.txtbookcond.Name = "txtbookcond";
            this.txtbookcond.Size = new System.Drawing.Size(197, 30);
            this.txtbookcond.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(611, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Condition";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtbookcat
            // 
            this.txtbookcat.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookcat.Location = new System.Drawing.Point(424, 162);
            this.txtbookcat.Name = "txtbookcat";
            this.txtbookcat.Size = new System.Drawing.Size(176, 30);
            this.txtbookcat.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(444, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 38);
            this.label4.TabIndex = 26;
            this.label4.Text = "Book List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Image";
            // 
            // picimg
            // 
            this.picimg.Location = new System.Drawing.Point(15, 260);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(247, 130);
            this.picimg.TabIndex = 24;
            this.picimg.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.B_Id,
            this.B_Title,
            this.B_Author,
            this.B_Category,
            this.B_Condition,
            this.B_Price,
            this.B_Quantity,
            this.B_Description,
            this.B_Image,
            this.Update,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 150;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 329);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(585, 309);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(141, 48);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(816, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(449, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantity";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(821, 162);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(197, 30);
            this.txtprice.TabIndex = 14;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(454, 260);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(197, 30);
            this.txtqty.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(417, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1053, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(214, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = " Title";
            // 
            // txtbookauthor
            // 
            this.txtbookauthor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookauthor.Location = new System.Drawing.Point(219, 160);
            this.txtbookauthor.Name = "txtbookauthor";
            this.txtbookauthor.Size = new System.Drawing.Size(197, 30);
            this.txtbookauthor.TabIndex = 4;
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktitle.Location = new System.Drawing.Point(15, 160);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.Size = new System.Drawing.Size(197, 30);
            this.txtbooktitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 37.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(436, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brosale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 770);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 732);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GhostWhite;
            this.button6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(20, 588);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(226, 56);
            this.button6.TabIndex = 15;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(20, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "User";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Books";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // B_Id
            // 
            this.B_Id.DataPropertyName = "B_Id";
            this.B_Id.HeaderText = "B_Id";
            this.B_Id.MinimumWidth = 6;
            this.B_Id.Name = "B_Id";
            this.B_Id.Width = 125;
            // 
            // B_Title
            // 
            this.B_Title.DataPropertyName = "B_Title";
            this.B_Title.HeaderText = "B_Title";
            this.B_Title.MinimumWidth = 6;
            this.B_Title.Name = "B_Title";
            this.B_Title.Width = 125;
            // 
            // B_Author
            // 
            this.B_Author.DataPropertyName = "B_Author";
            this.B_Author.HeaderText = "B_Author";
            this.B_Author.MinimumWidth = 6;
            this.B_Author.Name = "B_Author";
            this.B_Author.Width = 125;
            // 
            // B_Category
            // 
            this.B_Category.DataPropertyName = "B_Category";
            this.B_Category.HeaderText = "B_Category";
            this.B_Category.MinimumWidth = 6;
            this.B_Category.Name = "B_Category";
            this.B_Category.Width = 125;
            // 
            // B_Condition
            // 
            this.B_Condition.DataPropertyName = "B_Condition";
            this.B_Condition.HeaderText = "B_Condition";
            this.B_Condition.MinimumWidth = 6;
            this.B_Condition.Name = "B_Condition";
            this.B_Condition.Width = 125;
            // 
            // B_Price
            // 
            this.B_Price.DataPropertyName = "B_Price";
            this.B_Price.HeaderText = "B_Price";
            this.B_Price.MinimumWidth = 6;
            this.B_Price.Name = "B_Price";
            this.B_Price.Width = 125;
            // 
            // B_Quantity
            // 
            this.B_Quantity.DataPropertyName = "B_Quantity";
            this.B_Quantity.HeaderText = "B_Quantity";
            this.B_Quantity.MinimumWidth = 6;
            this.B_Quantity.Name = "B_Quantity";
            this.B_Quantity.Width = 125;
            // 
            // B_Description
            // 
            this.B_Description.DataPropertyName = "B_Description";
            this.B_Description.HeaderText = "B_Description";
            this.B_Description.MinimumWidth = 6;
            this.B_Description.Name = "B_Description";
            this.B_Description.Width = 125;
            // 
            // B_Image
            // 
            this.B_Image.DataPropertyName = "B_Image1";
            this.B_Image.HeaderText = "B_Image";
            this.B_Image.MinimumWidth = 6;
            this.B_Image.Name = "B_Image";
            this.B_Image.Width = 200;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 200;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 200;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1398, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookauthor;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbookcat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtbookdes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbookcond;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn B_Description;
        private System.Windows.Forms.DataGridViewImageColumn B_Image;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}