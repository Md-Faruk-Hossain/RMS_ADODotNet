using LinqToDB.Data;
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
    public partial class EmpUpdate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MD-FARUK-HOSSAI;Initial Catalog=RestaurantManagmantSystem;Integrated Security=True");
        public EmpUpdate()
        {
            InitializeComponent();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand(" UPDATE Employees  SET EmployeeId=@id, [Name] = @na, DesignationId=@de, PhoneNo = @ph, Gender=@ge,  DOB = @dob, NID = @nid, Email = @em, Joindate = @jd, [Address] = @ad, [Image]=@im WHERE EmployeeId = @id", con)) 
            {
               

                Image img = Image.FromFile(txtImgPath.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);


                con.Open();
                cmd.Parameters.AddWithValue("@id", cmdEmpIdUpdate.Text);
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
                MessageBox.Show("Employees Update Successfully");

                con.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" DELETE FROM Employees WHERE EmployeeId = @id", con);
            cmd.Parameters.AddWithValue("@id", cmdEmpIdUpdate.SelectedValue);              
            con.Open();

            if (cmd.ExecuteNonQuery() > 0) 
            {
                MessageBox.Show("Employees Delete Successfully");
                
            }
            con.Close();
            loadcombo();


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

        private void cmdEmpIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
        }

        private void EmpUpdate_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void loadcombo()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  DesignationId , TitleName FROM Designation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            cmdDesignationId.DisplayMember = "TitleName";
            cmdDesignationId.ValueMember = "DesignationId";
            cmdDesignationId.DataSource = ds.Tables[0];

            //Load cmbTutorId
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT EmployeeId FROM Employees", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmdEmpIdUpdate.DisplayMember = "EmployeeId";
            cmdEmpIdUpdate.ValueMember = "EmployeeId";
            cmdEmpIdUpdate.DataSource = dt2;
            con.Close();
    }

    private void btnBack_Click(object sender, EventArgs e)
        {
            EmpViewAll eva = new EmpViewAll();
            eva.Show();
            this.Hide();
        }

        private void cmdEmpIdUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT EmployeeId, [Name], DesignationId, PhoneNo, Gender, DOB, NID, Email, Joindate, [Address], [Image] FROM Employees WHERE EmployeeId =@id ";

            cmd.Parameters.AddWithValue("@id", cmdEmpIdUpdate.SelectedValue);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                txtName.Text = dr.GetString(1);
                cmdDesignationId.SelectedValue = dr.GetInt32(2);
                txtPhoneNo.Text = dr.GetString(3);                          
                if (dr.GetString(4) == rbtnMale.Text)
                {
                    rbtnMale.Checked = true;
                }
                if (dr.GetString(4) == rbtnFemale.Text)
                {
                    rbtnFemale.Checked = true;
                }
                dtpDateOfBirth.Value = dr.GetDateTime(5).Date;
                txtIdNo.Text = dr.GetString(6);
                txtEmail.Text = dr.GetString(7);
                dtpjoindate.Value = dr.GetDateTime(8).Date;
                txtAddress.Text = dr.GetString(9);
                pictureBox1Emp.Image = Image.FromStream(dr.GetStream(10));


            }
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
