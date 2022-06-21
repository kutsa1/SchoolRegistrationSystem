using DataAccess.Concrete.EntityFramework;
using System;


namespace UserInterface.Pages
{
    public partial class FrmCourseList : MaterialSkin.Controls.MaterialForm
    {
        public FrmCourseList()
        {
            InitializeComponent();
        }

        private void FrmCourseList_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EfCourseDal efCourseDal = new EfCourseDal();
            var courses = efCourseDal.getAllCourseDto();
            dataGridView1.DataSource = courses;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse frmCourse = new FrmCourse();
            frmCourse.Show();
            this.Close();
        }
    }
}
