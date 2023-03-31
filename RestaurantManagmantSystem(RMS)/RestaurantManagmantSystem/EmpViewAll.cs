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
    public partial class EmpViewAll : Form
    {
        public EmpViewAll()
        {
            InitializeComponent();
        }

        private void EmpViewAll_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True"))
                        
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Employees", con);
                con.Open();
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvEmpload.DataSource = dt;
                
                con.Close();
            }
            
        }

        private void btnEmpBack_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();
            this.Hide();
        }

        private void btnEmpEidt_Click(object sender, EventArgs e)
        {
            EmpUpdate eu = new EmpUpdate();
            eu.Show();
            this.Hide();
        }
    }
}
