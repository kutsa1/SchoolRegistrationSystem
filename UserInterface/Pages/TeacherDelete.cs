using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface.Pages
{
    public partial class FrmTeacherDelete : MaterialSkin.Controls.MaterialForm
    {
        List<InstructorDto> ınstructors;
        public FrmTeacherDelete()
        {
            InitializeComponent();
        }

        private void TeacherDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.Show();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EfInstructorDal efInstructor = new EfInstructorDal();
            ınstructors = efInstructor.GetAllTeacherDto();
            dataGridView1.DataSource=ınstructors;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(txtId.Text);
            EfUserDal efUserDal = new EfUserDal();
            efUserDal.Delete(user);
            MessageBox.Show("Instructor is deleted succesfully");
            btnList_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var user = ınstructors[e.RowIndex];
                txtId.Text = user.Id.ToString();
            }
        }
    }
}
