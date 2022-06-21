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
    public partial class FrmDeclareCourse : MaterialSkin.Controls.MaterialForm
    {
        public FrmDeclareCourse()
        {
            InitializeComponent();
        }

        private void DeclareCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse frmCourse = new FrmCourse();
            frmCourse.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved successfully");
        }
    }
}
