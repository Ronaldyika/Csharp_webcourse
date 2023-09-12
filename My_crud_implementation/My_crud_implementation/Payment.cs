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
        // Loading the foreign keys
void LoadForeignKeys()
{
    Constring _constring = new Constring();

    using (SqlConnection connection = new SqlConnection(_constring.constring))
    {
        connection.Open();

        // Load CustomerID
        string customerQuery = "SELECT CustomerID FROM tblCustomer";
        SqlCommand customerCmd = new SqlCommand(customerQuery, connection);
        SqlDataReader customerReader = customerCmd.ExecuteReader();
        cmbCustomerID.Items.Clear(); // Clear existing items before adding new ones
        while (customerReader.Read())
        {
            cmbCustomerID.Items.Add(customerReader["CustomerID"].ToString());
        }
        customerReader.Close();

        // Load MerchantID
        string merchantQuery = "SELECT MarchantID FROM tblMarchant";
        SqlCommand merchantCmd = new SqlCommand(merchantQuery, connection);
        SqlDataReader merchantReader = merchantCmd.ExecuteReader();
        cmbMarchantID.Items.Clear(); // Clear existing items before adding new ones
        while (merchantReader.Read())
        {
            cmbMarchantID.Items.Add(merchantReader["MarchantID"].ToString());
        }
        merchantReader.Close();
    }
}

        //load data


object LoadData()
{
    string query = "SELECT * FROM tblPayment";
    Constring _constring = new Constring();
    _constring._sqlcon = new SqlConnection(_constring.constring);
    _constring._sqlcon.Open();
    _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);
    _constring._sqlda = new SqlDataAdapter(_constring._sqlcmd);
    _constring._dt = new DataTable();
    _constring._sqlda.Fill(_constring._dt);
    if (_constring._dt.Rows.Count > 0)
    {
        return dgvPayment.DataSource = _constring._dt;
    }
    else
    {
        _constring._dt = null;
        return _constring._dt;
    }

    LoadData();
}
        //datagrid view

void dgvMarchant()
{
    lblID.Text = dgvPayment.SelectedRows[0].Cells[0].Value.ToString();
    txtAmount.Text = dgvPayment.SelectedRows[0].Cells[1].Value.ToString();
    cmbCustomerID.Text = dgvPayment.SelectedRows[0].Cells[2].Value.ToString();
    cmbMarchantID.Text = dgvPayment.SelectedRows[0].Cells[3].Value.ToString();
}


// Declaring the create function
void Create()
{
    if (txtAmount.Text == "")
    {
        MessageBox.Show("Invalid parameters", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else if (cmbCustomerID.SelectedItem == null || cmbMarchantID.SelectedItem == null)
    {
        MessageBox.Show("Please select a Customer ID and Merchant ID", "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
        Constring _constring = new Constring();

        using (SqlConnection connection = new SqlConnection(_constring.constring))
        {
            connection.Open();

            // Insert data into tblPayment
            string query = "INSERT INTO tblPayment (Amount, CustomerID, MerchantID) VALUES (@Amount, @CustomerID, @MerchantID)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
            cmd.Parameters.AddWithValue("@CustomerID", cmbCustomerID.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@MerchantID", cmbMarchantID.SelectedItem.ToString());
            int i = cmd.ExecuteNonQuery();

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
            LoadData();
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
