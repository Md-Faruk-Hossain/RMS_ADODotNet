using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagmantSystem
{
    public partial class FoodMenu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True");

        public FoodMenu()
        {
            InitializeComponent();
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Menugroup VALUES(@id, @fn)", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtCategoryId.Text);
                cmd.Parameters.AddWithValue("@fn", txtfoodName.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("FoodMenu Added Successfully");

                con.Close();
                loadGrid();
            }
        }

        private void loadGrid()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True")) {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Menugroup", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
               
          
        }

      
       

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (txtCategoryId.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(" DELETE FROM Menugroup WHERE CatagoryId= '" + int.Parse(txtCategoryId.Text) + "' ", con);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("FoodMenu Delete Successfully");
                loadGrid();

            }
            else {
                MessageBox.Show("FoodMenu Product Id");
            }


            
        }

        

    }
}
