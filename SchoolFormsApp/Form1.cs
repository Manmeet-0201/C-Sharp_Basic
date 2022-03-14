using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkedInClassDemo;
namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name =txtSchoolName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var Student = new Student();
            var gp = Student.ComputeGradeAverage();
            MessageBox.Show("the grade average is" + gp);


        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("the grade average is" + gp);

        }
    }
}
