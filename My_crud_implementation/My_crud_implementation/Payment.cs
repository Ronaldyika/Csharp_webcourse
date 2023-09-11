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
    public partial class Payment : Form
    {
        //calling the constring class

        public class Constring{
            public string constring = @"Data Source=.\SQLSERVER2014;Initial Catalog=PaymentDB;Integrated Security=True";
            public SqlConnection _sqlcon = new SqlConnection();
            public SqlCommand _sqlcmd = new SqlCommand();
            public SqlDataAdapter _sqlda = new SqlDataAdapter();
            public SqlDataReader dr;
            public DataTable _dt = new DataTable();

        }

        // declaring the clearall function

        void ClearAll()
        {
            txtAmount.Clear();
            txtCustomerID.Text = "";
        }
        //loading the foriegn key

        void LoadForeignKeys()
        {
            Constring _constring = new Constring();

            using (SqlConnection connection = new SqlConnection(_constring.constring))
            {
                connection.Open();

                // Load CustomerID
                string customerQuery = "SELECT TOP 1 CustomerID FROM tblCustomer";
                SqlCommand customerCmd = new SqlCommand(customerQuery, connection);
                object customerID = customerCmd.ExecuteScalar();
                if (customerID != null)
                {
                    txtCustomerID.Text = customerID.ToString();
                }

                // Load MarchantID
                string merchantQuery = "SELECT TOP 1 MarchantID FROM tblMarchant";
                SqlCommand merchantCmd = new SqlCommand(merchantQuery, connection);
                object merchantID = merchantCmd.ExecuteScalar();
                if (merchantID != null)
                {
                    txtMarchant.Text = merchantID.ToString();
                }
            }
        }


        //declaring the create function
        void Create()
        {
            string query1 = "SELECT TOP 1 CustomerID FROM tblCustomer";
            string query2 = "SELECT TOP 1 MarchantID FROM tblMarchant";

            if (txtAmount.Text == "" || txtCustomerID.Text == "" || txtMarchant.Text == "")
            {
                MessageBox.Show("Invalid parameters", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Constring _constring = new Constring();

                using (SqlConnection connection = new SqlConnection(_constring.constring))
                {
                    connection.Open();

                    // Retrieve CustomerID from tblCustomer
                    SqlCommand cmd1 = new SqlCommand(query1, connection);
                    object customerID = cmd1.ExecuteScalar();
                    if (customerID != null)
                    {
                        txtCustomerID.Text = customerID.ToString();
                    }

                    // Retrieve MarchantID from tblMarchant
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    object merchantID = cmd2.ExecuteScalar();
                    if (merchantID != null)
                    {
                        txtMarchant.Text = merchantID.ToString();
                    }

                    // Insert data into tblPayment
                    string query = "INSERT INTO tblPayment (Amount, CustomerID, MerchantID) VALUES (@Amount, @CustomerID, @MerchantID)";
                    SqlCommand cmd3 = new SqlCommand(query, connection);
                    cmd3.Parameters.AddWithValue("@Amount", txtAmount.Text);
                    cmd3.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd3.Parameters.AddWithValue("@MerchantID", txtMarchant.Text);
                    int i = cmd3.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("New Payment Details saved", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Payment information not saved", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ClearAll();
                }
            }
        }
        public Payment()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Yika().Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtAmount.Focus();
            LoadForeignKeys();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
