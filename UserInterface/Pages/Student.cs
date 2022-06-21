using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;
using UserInterface.Pages;

namespace UserInterface
{
    public partial class FrmStudent : MaterialSkin.Controls.MaterialForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            User user = new User();
            user.Gender = rdMale.Checked? true:false;
            user.Address = txtAddress.Text;
            user.Birthday = dtDOB.Value;
            user.Phone = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.NationalityId = txtId.Text;
            EfUserDal userDal = new EfUserDal();
            userDal.Add(user);
            var EntityUser = userDal.Get(u => u.NationalityId == user.NationalityId);

            Student student = new Student();
            student.StudentNo = txtStdNo.Text;
            student.UserId = EntityUser.Id;
            new EfStudentDal().Add(student);
            MessageBox.Show("Student is added succesfully");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentList studentList = new FrmStudentList();
            studentList.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentDelete frmStudentDelete = new FrmStudentDelete();
            frmStudentDelete.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentUpdate frmStudentUpdate = new FrmStudentUpdate();
            frmStudentUpdate.Show();
            this.Close();
        }
    }
}
