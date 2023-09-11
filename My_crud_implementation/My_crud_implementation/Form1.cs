using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace My_crud_implementation
{
    public partial class Yika : Form
    {
        public void Constring()
        {
            string constring = @"Data Source=.\SQLSERVER2014;Initial Catalog=PaymentDB;Integrated Security=True";
            SqlConnection _sqlcon = new SqlConnection();
            SqlCommand _sqlcmd = new SqlCommand();
            SqlDataAdapter _sqlda = new SqlDataAdapter();
            SqlDataReader dr;
            DataTable _dt = new DataTable();

        }

         Constring _constring = new Constring();


        public Yika()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void Yika_Load(object sender, EventArgs e)
        {
            btnMarchant.Focus();
        }

        private void btnMarchant_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentCrud_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }

        private void btnMarchantCrud_Click(object sender, EventArgs e)
        {
            new Marchant().Show();
            this.Hide();
        }

        private void btnCustomerCrud_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }
    }
}
