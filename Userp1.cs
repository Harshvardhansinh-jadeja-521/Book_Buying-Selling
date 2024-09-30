using System;
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
using System.Diagnostics;

namespace Project_brosale
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Userp1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Study_material\C#_Project\Brosale\Project_brosale\BrosaleDB.mdf;Integrated Security=True;Connect Timeout=30";

        void connection()
        {
            con = new SqlConnection(s);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private PictureBox pic;

        public Userp1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define button click event logic here
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Define PictureBox click event logic here
        }

        private void Userp1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            connection();
            try
            {
                cmd = new SqlCommand("SELECT B_Image FROM Book_tbl", con);
                dr = cmd.ExecuteReader();

                // Check if there are any rows
                if (!dr.HasRows)
                {
                    MessageBox.Show("No images found in the database.");
                    return;
                }

                while (dr.Read())
                {
                    if (dr.IsDBNull(0)) // Check for NULL values in the B_Image column
                    {
                        MessageBox.Show("Image data is null.");
                        continue; // Skip this record
                    }

                    // Get the image data
                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[len];

                    dr.GetBytes(0, 0, array, 0, (int)len);

                    // Ensure that the byte array is not empty or invalid
                    if (array.Length == 0)
                    {
                        MessageBox.Show("Image data is empty.");
                        continue;
                    }

                    try
                    {
                        // Create a PictureBox for each image
                        pic = new PictureBox
                        {
                            Width = 100,
                            Height = 100,
                            BackgroundImageLayout = ImageLayout.Stretch
                        };

                        // Create an image from the byte array
                        using (MemoryStream ms = new MemoryStream(array))
                        {
                            Bitmap bitmap = new Bitmap(ms);
                            pic.BackgroundImage = bitmap;
                        }

                        // Add PictureBox to the FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pic);
                    }
                    catch (Exception imgEx)
                    {
                        MessageBox.Show("Image loading failed: " + imgEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the SqlDataReader and connection
                if (dr != null)
                    dr.Close();
                if (con != null)
                    con.Close();
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
