using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Pages;

namespace UserInterface
{
    public partial class FrmTeacher : MaterialSkin.Controls.MaterialForm
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            user.Gender = rdMale.Checked ? true : false;
            user.Phone = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.Birthday = dtDOB.Value;
            user.NationalityId = txtNationalityId.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Address = txtAddress.Text;
            EfUserDal efUserDal = new EfUserDal();
            efUserDal.Add(user);
            var EntityUser = efUserDal.Get(u => u.NationalityId == user.NationalityId);
            Instructor instructor = new Instructor();
            instructor.Title = txtTitle.Text;
            instructor.UserId = EntityUser.Id;
            instructor.Salary = Convert.ToDecimal(txtSalary.Text);
            new EfInstructorDal().Add(instructor);
            MessageBox.Show("Teacher is saved successfully");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacherList frmTeacherList = new FrmTeacherList();
            frmTeacherList.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacherDelete frmTeacherDelete = new FrmTeacherDelete();
            frmTeacherDelete.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacherUpdate frmTeacherUpdate = new FrmTeacherUpdate();
            frmTeacherUpdate.Show();
            this.Close();
        }
    }
}
