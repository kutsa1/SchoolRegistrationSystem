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
    public partial class FrmSchoolRegSys : MaterialSkin.Controls.MaterialForm
    {
        public FrmSchoolRegSys()
        {
            InitializeComponent();
        }

        private void FrmSchoolRegSys_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudent student = new FrmStudent();
            student.Show();
            this.Close();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTeacher teacher = new FrmTeacher();
            teacher.Show();
            this.Close();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFee fee = new FrmFee();
            fee.Show();
            this.Close();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReports frmReports = new FrmReports();  
            frmReports.Show();
            this.Close();


        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse frmClass = new FrmCourse();
            frmClass.Show();
            this.Close();
        }
    }
}
