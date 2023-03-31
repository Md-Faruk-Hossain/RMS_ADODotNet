using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagmantSystem
{
    public partial class FoodDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True");

        public FoodDetails()
        {
            InitializeComponent();
        }

       
        private void FoodDetails_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CatagoryId , MenuName FROM Menugroup", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmdCatName.DataSource = dt;
                cmdCatName.DisplayMember = "MenuName";
                cmdCatName.ValueMember = "CatagoryId";
                con.Close();

            }

        }

        private void btnImgload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1Emp.Image = img;
                txtImgPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO ItemDetails VALUES (@im, @id, @cn, @in, @pr)", con))
            {
                Image img = Image.FromFile(txtImgPath.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

                con.Open();

                cmd.Parameters.Add(new SqlParameter("@im", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@id", txtItemId.Text);
                cmd.Parameters.AddWithValue("@cn", cmdCatName.SelectedValue);
                cmd.Parameters.AddWithValue("@in", txtItemName.Text);
                cmd.Parameters.AddWithValue("@pr", txtPrice.Text);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food Datails Added Successfully");
                    
                con.Close();
            }
        }
       
       

      
       
    }
}
