using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmCredit_Cart : MaterialSkin.Controls.MaterialForm
    {
        List<StudentDto> students;
        List<CourseDto> courses;
        EfStudentDal efStudentDal = new EfStudentDal();
        EfCourseDal efCourseDal = new EfCourseDal();
        EfPaymentDal efPaymentDal = new EfPaymentDal();
        public FrmCredit_Cart()
        {
            InitializeComponent();
        }

        private void FrmCredit_Cart_Load(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.iscash = false;
            students = efStudentDal.GetAllStudentDto();
            foreach (var item in students)
            {
                cmbStudent.Items.Add($"{item.FirstName} {item.LastName}");
            }
            courses = efCourseDal.getAllCourseDto();
            foreach (var item in courses)
            {
                cmbCourse.Items.Add(item.CourseName);
            }
        }

        private void chkInstallment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            var efPaymetDal = new EfPaymentDal();
            Payment payment = new Payment();

            CourseDto course = courses[cmbCourse.SelectedIndex];
            StudentDto student = students[cmbStudent.SelectedIndex];


            payment.Amount = course.Price;
            payment.CourseId = course.Id;
            payment.Status = false;
            payment.iscash = false;
            payment.StudentId = student.Id;
            for (int i = 0; i < Convert.ToInt32(cmbInstallment.Text); i++)
            {
                payment = new Payment();


                payment.CourseId = course.Id;
                payment.Status = false;
                payment.StudentId = student.Id;
                if (month == 12)
                {
                    month = 1;
                    year++;
                }
                else
                {
                    month++;
                }
                payment.Date = new DateTime(year, month, day);
                payment.Amount = course.Price / Convert.ToInt32(cmbInstallment.Text);               
                efPaymetDal.Add(payment);
            }
            dataGridView1.DataSource = efPaymentDal.GetAllPaymentDto();
            MessageBox.Show("Payment is successfully");
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFee frmFee = new FrmFee();
            frmFee.Show();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efPaymentDal.GetAllPaymentDto();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

       
    }
}
