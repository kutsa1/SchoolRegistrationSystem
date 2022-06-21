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

namespace UserInterface
{
    public partial class FrmFee : MaterialSkin.Controls.MaterialForm
    {
        public FrmFee()
        {
            InitializeComponent();
        }

        private void Fee_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCash frmCash = new FrmCash();
            frmCash.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            FrmCredit_Cart frmCredit_Cart = new FrmCredit_Cart();
            frmCredit_Cart.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchoolRegSys frmSchoolRegSys = new FrmSchoolRegSys();
            frmSchoolRegSys.Show();
            this.Close();
        }
    }
}
