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
    public partial class FoodDetailsView : Form
    {
        public FoodDetailsView()
        {
            InitializeComponent();
        }

        private void FoodDetailsView_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True"))

            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ItemDetails", con);
                con.Open();

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
        }
    }
}
