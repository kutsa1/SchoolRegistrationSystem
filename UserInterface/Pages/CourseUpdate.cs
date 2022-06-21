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

namespace UserInterface.Pages
{
    public partial class FrmCourseUpdate : MaterialSkin.Controls.MaterialForm
    {
        List<InstructorDto> ins;
        List<CourseDto> courses;
        EfCourseDal _efCourseDal = new EfCourseDal();
        int id;
        public FrmCourseUpdate()
        {
            InitializeComponent();
        }

        private void FrmCourseUpdate_Load(object sender, EventArgs e)
        {
            courses =  _efCourseDal.getAllCourseDto();
            ins = new EfInstructorDal().GetAllTeacherDto();
            foreach (var item in ins)
            {
                cmbInstructors.Items.Add($"{item.Name}  {item.LastName}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse frmCourse = new FrmCourse();
            frmCourse.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var course = courses[e.RowIndex];
                id = course.Id;
                txtCourseName.Text = course.CourseName;
                txtCourseNote.Text = course.Description;
                txtPrice.Text = course.Price.ToString();
                rdFallSemester.Checked = course.Semester =="Fall" ? true : false;
                rdSpringSemester.Checked = course.Semester == "Spring" ? true : false;
                cmbInstructors.Text = course.InstructorName + " " + course.InstructorLastName;


            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = _efCourseDal.getAllCourseDto();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Course course = _efCourseDal.Get(c => c.Id == id);
            course.InstructorId = ins[cmbInstructors.SelectedIndex].Id;
            course.Name = txtCourseName.Text;
            course.Price = Convert.ToDecimal(txtPrice.Text);
            course.Description = txtCourseNote.Text;
            course.Semester = rdFallSemester.Checked ? "Fall" : "Spring";
           _efCourseDal.Update(course);
            courses = _efCourseDal.getAllCourseDto();
            MessageBox.Show("Course is update succesfully");
            btnList_Click(sender, e);
        }

        private void cmbInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
