using DataAccess.Concrete.EntityFramework;
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
    public partial class FrmStudentList : MaterialSkin.Controls.MaterialForm
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EfStudentDal efStudentDal = new EfStudentDal();
            var users = efStudentDal.GetAllStudentDto();
            dataGridView1.DataSource = users;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
            this.Hide();
        }
    }
}
