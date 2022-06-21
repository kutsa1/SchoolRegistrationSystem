using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UserInterface.Pages;

namespace UserInterface
{
    public partial class FrmCourse : MaterialSkin.Controls.MaterialForm
    {
        List<InstructorDto> ins;
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourseDelete frmCourseDelete = new FrmCourseDelete();
            frmCourseDelete.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchoolRegSys frmSchoolRegSys = new FrmSchoolRegSys();
            frmSchoolRegSys.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Course course = new Course(); 
            course.InstructorId = ins[cmbInstructors.SelectedIndex].Id;
            course.Name = txtCourseName.Text;
            course.Price = Convert.ToDecimal(txtPrice.Text);
            course.Description = txtCourseNote.Text;
            course.Semester = rdFallSemester.Checked ? "Fall" : "Spring";
            EfCourseDal efCourseDal = new EfCourseDal();
            efCourseDal.Add(course);
            MessageBox.Show("Course is added succesfully");


        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
          ins = new EfInstructorDal().GetAllTeacherDto();
            foreach (var item in ins)
            {
                cmbInstructors.Items.Add($"{item.Name}  {item.LastName}");
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourseList frmCourseList = new FrmCourseList();
            frmCourseList.Show();
            this.Close();
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourseUpdate frmCourseUpdate = new FrmCourseUpdate();
            frmCourseUpdate.Show();
            this.Close();
        }
    }
}
