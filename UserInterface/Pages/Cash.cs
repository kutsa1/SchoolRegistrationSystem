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
    public partial class FrmCash : MaterialSkin.Controls.MaterialForm
    {
        List<StudentDto> students;
        List<CourseDto> courses;
        EfStudentDal efStudentDal = new EfStudentDal(); 
        EfCourseDal efCourseDal = new EfCourseDal();
        EfPaymentDal efPaymentDal = new EfPaymentDal();
        public FrmCash()
        {
            InitializeComponent();
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.iscash = true;
            students = efStudentDal.GetAllStudentDto();
            foreach (var item in students)
            {
                cbStudent.Items.Add($"{item.FirstName} {item.LastName}");
            }
             courses = efCourseDal.getAllCourseDto();
            foreach (var item in courses)
            {
                cmbCourse.Items.Add(item.CourseName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFee frmFee = new FrmFee();
            frmFee.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Payment payment = new Payment();
            CourseDto course = courses[cmbCourse.SelectedIndex];
            StudentDto student = students[cbStudent.SelectedIndex];
            payment.Date = date;
            payment.Status = true;
            payment.StudentId = student.Id;
            payment.CourseId = course.Id;
            payment.Amount = course.Price;
            payment.iscash = true;
            efPaymentDal.Add(payment);
            dataGridView1.DataSource = efPaymentDal.GetAllPaymentDto();
            MessageBox.Show("Payment is successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efPaymentDal.GetAllPaymentDto();
        }
    }
}
