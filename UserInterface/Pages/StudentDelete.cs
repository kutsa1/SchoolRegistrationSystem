using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface.Pages
{
    public partial class FrmStudentDelete : MaterialSkin.Controls.MaterialForm
    {
        List<StudentDto> users;
        public FrmStudentDelete()
        {
            InitializeComponent();
        }

        private void FrmStudentDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

            EfStudentDal efStudentDal = new EfStudentDal();
            users = efStudentDal.GetAllStudentDto();
            dataGridView1.DataSource = users;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(txtId.Text);
            EfUserDal efUserDal = new EfUserDal();
            efUserDal.Delete(user);
            MessageBox.Show("Student is deleted succesfully");
            btnList_Click(sender, e);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var user = users[e.RowIndex];
                txtId.Text = user.Id.ToString();
                
            }
        }
    }
}
