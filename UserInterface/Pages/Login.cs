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
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm

    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password can not be blank.", "Warning!");
            }
            else
            {
                if (txtId.Text == "admin" && txtPassword.Text == "admin")
                {
                    FrmSchoolRegSys frmSchoolRegSys = new FrmSchoolRegSys();
                    frmSchoolRegSys.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username or passsword is incorrect.", "Warning!");
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
