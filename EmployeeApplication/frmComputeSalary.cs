using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void compute_Click(object sender, EventArgs e)
        {
            PartTimeEmployee pte = new PartTimeEmployee(firstname.Text, lastname.Text, department.Text, jobtitle.Text);

            int hours = Convert.ToInt32(hoursworked.Text);
            double rate = Convert.ToDouble(rateperhour.Text);

            pte.computeSalary(hours, rate);

            resultname.Text = pte.FirstName;
            resultlast.Text = pte.LastName;
            resultsalary.Text = Convert.ToString(pte.getSalary());

        }
    }
}
