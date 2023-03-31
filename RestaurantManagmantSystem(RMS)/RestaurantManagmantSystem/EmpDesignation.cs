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
    public partial class EmpDesignation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True");


        public EmpDesignation()
        {
            InitializeComponent();
        }

        private void EmpDesignation_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True"))
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Designation", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Designation VALUES(@id, @dn)", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@id", txtDesigId.Text);
                cmd.Parameters.AddWithValue("@dn", txtDesigName.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Designation Added Successfully");

                con.Close();
                loadGrid();
            }
        }

      
        private void Back_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();
            this.Hide();
        }

       
        private void btnDesigDelete_Click(object sender, EventArgs e)
        {
            if (txtDesigId.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Designation WHERE DesignationId= '" + int.Parse(txtDesigId.Text) + "' ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Designation Delete Successfully");
                loadGrid();

            }
            else
            {
                MessageBox.Show("Designation Product Id");
            }

        }

       
    }
}
