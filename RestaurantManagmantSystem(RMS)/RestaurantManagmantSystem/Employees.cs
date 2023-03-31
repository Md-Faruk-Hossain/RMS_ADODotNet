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
    public partial class Employees : Form
    {
       
        
        SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True");

        public Employees()
        {
            InitializeComponent();
        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES(@id, @na, @de, @ph, @ge, @dob, @nid, @em, @jd, @ad, @im)", con))
            {
                Image img = Image.FromFile(txtImgPath.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);

               
                    con.Open();
                cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@na", txtName.Text);
                cmd.Parameters.AddWithValue("@de", cmdDesignationId.SelectedValue);
                cmd.Parameters.AddWithValue("@ph", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@ge", (rbtnMale.Checked) ? rbtnMale.Text : rbtnFemale.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value.Date);
                cmd.Parameters.AddWithValue("@nid", txtIdNo.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@jd", dtpjoindate.Value.Date);
                cmd.Parameters.AddWithValue("@ad", txtAddress.Text);
                cmd.Parameters.Add(new SqlParameter("@im", SqlDbType.VarBinary) { Value = ms.ToArray() });
                          
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employeee Added Successfully");

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

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadCombo();


        }

       

        private void LoadCombo()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True")) 
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Titlename,DesignationId FROM Designation", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmdDesignationId.DataSource = dt;
                cmdDesignationId.DisplayMember = "Titlename";
                cmdDesignationId.ValueMember = "DesignationId";
                con.Close();
            }

        }

        private void btnEmpViewAll_Click(object sender, EventArgs e)
        {
            EmpViewAll ev = new EmpViewAll();
            ev.Show();
            this.Hide();
        }

        private void btnBackEmp_Click(object sender, EventArgs e)
        {
            EmpDesignation ed = new EmpDesignation();
            ed.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

        
    
