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
    public partial class FrmCourseDelete : MaterialSkin.Controls.MaterialForm
    {
        List<CourseDto> courses;
        public FrmCourseDelete()
        {
            InitializeComponent();
        }

        private void FrmCourseDelete_Load(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            courses = efCourseDal.getAllCourseDto();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            dataGridView1.DataSource = efCourseDal.getAllCourseDto();
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
                txtId.Text = course.Id.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Id = Convert.ToInt32(txtId.Text);
            EfCourseDal efCourseDal = new EfCourseDal();
            efCourseDal.Delete(course);
            courses = efCourseDal.getAllCourseDto();
            MessageBox.Show("Course is deleted succesfully");
            btnList_Click(sender, e);
        }
    }
}
