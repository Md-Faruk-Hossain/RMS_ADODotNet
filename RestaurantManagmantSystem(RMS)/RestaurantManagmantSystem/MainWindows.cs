using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagmantSystem
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpDesignation ed = new EmpDesignation();
            ed.Show();
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindows mn = new MainWindows();
            this.Close();
           
        }

        private void employeeInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.Show();

        }

        private void employeeUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpUpdate eu = new EmpUpdate();
            eu.Show();

        }

        private void viewListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmpViewAll eva = new EmpViewAll();
            eva.Show();

        }

        private void foodMeneInsertDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            fm.Show();
        }

        private void foodInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodDetails fd = new FoodDetails();
            fd.Show();
        }

        private void foodUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodDetailsUpdate fdu = new FoodDetailsUpdate();
            fdu.Show();
        }

        private void foodViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodDetailsView fdv = new FoodDetailsView();
            fdv.Show();
        }
    }

}
