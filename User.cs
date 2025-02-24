﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Project_brosale
{
    public partial class User : Form
    {
        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study_material\C#_Project\Brosale\Project_brosale\BrosaleDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int id;
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }


        public User()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void fillg()
        {


            connection();
            da = new SqlDataAdapter("select U_Id, U_Fname , U_Lname , U_Uname , U_Phone , U_State  from user_tbl ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            connection();
            if (button1.Text=="Save")
            {
               
                cmd = new SqlCommand("insert into user_tbl (U_Fname , U_Lname , U_Uname , U_Phone , U_State )values ('" + txtfname.Text + "' , '" + txtlname.Text + "' , '" + txtuname.Text + "' , '" + txtphone.Text + "' , '" + txtstate.Text + "')", con);
                cmd.ExecuteNonQuery();
                fillg();
            }
            else
            {
                cmd = new SqlCommand("update user_tbl set U_Fname='" + txtfname.Text + "' , U_Lname='" + txtlname.Text + "' , U_Uname='" + txtuname.Text + "' , U_Phone='" + txtphone.Text + "', U_State='" + txtstate.Text + "'  where U_Id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                fillg();
            }
        }
           

        private void User_Load(object sender, EventArgs e)
        {
            connection();
            fillg();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection();
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                button1.Text = "Update";
                
                id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["U_Id"].Value);
                string fname, lname, uname, phone, state;

                fname = dataGridView1.Rows[e.RowIndex].Cells["Fname"].Value.ToString();
                lname = dataGridView1.Rows[e.RowIndex].Cells["Lname"].Value.ToString();
                uname = dataGridView1.Rows[e.RowIndex].Cells["Uname"].Value.ToString();
                phone = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                state = dataGridView1.Rows[e.RowIndex].Cells["State"].Value.ToString();

                txtfname.Text = fname;
                txtlname.Text = lname;
                txtuname.Text = uname;
                txtphone.Text = phone;
                txtstate.Text = state;
            }
            else
            {
                connection();
                id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["U_Id"].Value);

                cmd = new SqlCommand("delete from user_tbl where U_Id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Record");
                fillg();
            }
        }
    }
}
