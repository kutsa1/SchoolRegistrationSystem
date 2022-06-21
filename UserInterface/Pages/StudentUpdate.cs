using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface.Pages
{
    public partial class FrmStudentUpdate : MaterialSkin.Controls.MaterialForm
    {
        EfStudentDal efStudentDal;
        List<StudentDto> users;
        int id;
        public FrmStudentUpdate()
        {
            efStudentDal = new EfStudentDal();
            InitializeComponent();
        }

        private void StudentUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            users = efStudentDal.GetAllStudentDto();
            dataGridView1.DataSource = users;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                var user = users[e.RowIndex];
                id = user.Id;
                txtAddress.Text = user.Address;
                txtEmail.Text = user.Email;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtPhoneNumber.Text = user.Phone;
                txtStdNo.Text = user.StudentNo;
                txtId.Text = user.NationalityId;
                rdFemale.Checked = user.Gender ? false : true;



                rdMale.Checked = user.Gender ? true : false;

            }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var efUserDal = new EfUserDal();
            var efStudentDal = new EfStudentDal();
            var user = efUserDal.Get(u => u.Id == id);
            user.Gender = rdMale.Checked ? true : false;
            user.Address = txtAddress.Text;
            user.Birthday = dtDOB.Value;
            user.Phone = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.NationalityId = txtId.Text;
            efUserDal.Update(user);
            Student student = efStudentDal.Get(s => s.UserId == user.Id);
            student.StudentNo = txtStdNo.Text;
            new EfStudentDal().Update(student);
            MessageBox.Show("Student is update succesfully");
            btnList_Click( sender, e);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
            this.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
