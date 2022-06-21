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
    public partial class FrmTeacherUpdate : MaterialSkin.Controls.MaterialForm
    {
        List<InstructorDto> users;
        EfInstructorDal efInstructorDal;
        int Id;

        public FrmTeacherUpdate()
        {
            efInstructorDal = new EfInstructorDal();
            InitializeComponent();
        }

        private void FrmTeacherUpdate_Load(object sender, EventArgs e)
        {

        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    var efUserDal = new EfUserDal();
        //    efInstructorDal = new EfInstructorDal();
        //    var user = efUserDal.Get(u => u.NationalityId == txtNationalityId.Text);
        //    user.Gender = rdMale.Checked ? true : false;
        //    user.FirstName = txtFirstName.Text;
        //    user.LastName = txtLastName.Text;
        //    user.Address = txtAddress.Text;
        //    user.Phone = txtPhoneNumber.Text;
        //    user.Birthday = dtDOB.Value;
        //    user.Email = txtEmail.Text;
        //    user.NationalityId = txtNationality.Text;
        //    efUserDal.Update(user);
        //    Instructor instructor = efInstructorDal.Get(i => i.UserId == user.Id);
        //    instructor.Salary = Convert.ToInt32(txtSalary.Text);
        //    instructor.Title = txtTitle.Text;
        //    new EfInstructorDal().Update(instructor);
        //    MessageBox.Show("Student is update succesfully");
        //    btnList_Click(sender, e);
        //}

        private void btnList_Click(object sender, EventArgs e)
        {
            users = efInstructorDal.GetAllTeacherDto();
            dataGridView1.DataSource = users;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var user = users[e.RowIndex];
                txtAddress.Text = user.Address;
                txtEmail.Text = user.Email;
                txtFirstName.Text = user.Name;
                txtLastName.Text = user.LastName;
                txtPhoneNumber.Text = user.PhoneNumber;
                txtNationalityId.Text = user.NationalityId;
                rdFemale.Checked = user.Gender ? false : true;
                rdMale.Checked = user.Gender ? true : false;
                txtTitle.Text = user.Title;
                txtSalary.Text = user.Salary.ToString();
                Id = user.Id;
            }
        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var efUserDal = new EfUserDal();
            var efInstructorDal = new EfInstructorDal();
            var user = efUserDal.Get(u => u.Id == Id );
            user.Address = txtAddress.Text;
            user.Gender = rdMale.Checked ? true : false;
            user.Birthday = dtDOB.Value;
            user.Phone = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.NationalityId = txtNationalityId.Text;
            efUserDal.Update(user);
            Instructor ınstructor = efInstructorDal.Get(ı => ı.UserId == user.Id);
            ınstructor.Salary = Convert.ToDecimal(txtSalary.Text);
            ınstructor.Title = txtTitle.Text;
            new EfInstructorDal().Update(ınstructor);
            MessageBox.Show("Instructor is update succesfully");
            btnList_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.Show();
            this.Close();
        }
    }
}
