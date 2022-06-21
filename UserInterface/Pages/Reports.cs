using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
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
    public partial class FrmReports : MaterialSkin.Controls.MaterialForm
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var payments = efPaymentDal.GetAll(p => !p.Status);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = payments;
        }

        private void btn3Earn_Click(object sender, EventArgs e)
        {
            decimal totalprice =0;
            DateTime date = DateTime.Now;
            int month = date.Month;
            int day = date.Day;
            int year = date.Year;
            month += 3;
            DateTime dateTime = new DateTime(year, month, day);
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var payments = efPaymentDal.GetAll(p => p.Date < dateTime);
            foreach (var payment in payments)
            {
                totalprice += payment.Amount; 

            }
            label4.Text = btn3Earn.Text;
            label2.Text = totalprice.ToString();
        }
        private void btnPaymentPeriod_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int month = date.Month;
            int day = date.Day;
            int year = date.Year;
            DateTime dateTime = new DateTime(year, month, day);
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var result = efPaymentDal.GetAll(p => p.Date.Month - month <= 2);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = result;
            

        }

        private void btn1Earn_Click(object sender, EventArgs e)
        {
            decimal totalprice = 0;
            DateTime date = DateTime.Now;
            int month = date.Month;
            int day = date.Day;
            int year = date.Year;
            month += 1;
            DateTime dateTime = new DateTime(year, month, day);
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var payments = efPaymentDal.GetAll(p => p.Date < dateTime);
            foreach (var payment in payments)
            {
                totalprice += payment.Amount;

            }
            label4.Text = btn1Earn.Text;
            label2.Text = totalprice.ToString();
        }

        private void btnCashSum_Click(object sender, EventArgs e)
        {
            Decimal totalprice = 0;
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var cashSum = efPaymentDal.GetAll(p => p.iscash == true);
            foreach (var payment in cashSum)
            {
                totalprice += payment.Amount;
            }
            label4.Text = btnCashSum.Text;
            label2.Text = totalprice.ToString();

        }

        private void btnCreditCartSum_Click(object sender, EventArgs e)
        {
            Decimal totalprice = 0;
            EfPaymentDal efPaymentDal = new EfPaymentDal();
            var cashSum = efPaymentDal.GetAll(p => p.iscash == false);
            foreach (var payment in cashSum)
            {
                totalprice += payment.Amount;
            }
            label4.Text = btnCreditCartSum.Text;
            label2.Text = totalprice.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSchoolRegSys frmSchoolRegSys = new FrmSchoolRegSys();
            frmSchoolRegSys.Show();
            this.Close();
        }

        private void btn1MounthMissed_Click(object sender, EventArgs e)
        {
        }

       
    }

}
