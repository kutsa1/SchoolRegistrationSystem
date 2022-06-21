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

namespace UserInterface
{
    public partial class FrmTeacherList : MaterialSkin.Controls.MaterialForm

    {
        public FrmTeacherList()
        {
            InitializeComponent();
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            EfInstructorDal efInstructorDal = new EfInstructorDal();
            var users = efInstructorDal.GetAllTeacherDto();
            dataGridView1.DataSource = users;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.Show();
            this.Hide();
        }
    }
}
