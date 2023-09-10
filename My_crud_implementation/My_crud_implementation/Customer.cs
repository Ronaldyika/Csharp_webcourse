using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_crud_implementation
{
    public partial class Customer : Form
    {
        object LoadData()
        {
            string query = "SELECT * FROM tblCustomer";
            Constring _constring = new Constring();
            _constring._sqlcon = new SqlConnection(_constring.constring);
            _constring._sqlcon.Open();
            _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);
            _constring._sqlda = new SqlDataAdapter(_constring._sqlcmd);
            _constring._dt = new DataTable();
            _constring._sqlda.Fill(_constring._dt);
            if (_constring._dt.Rows.Count > 0)
            {
                return dgvCustomer.DataSource = _constring._dt;
            }
            else
            {
                _constring._dt = null;
                return _constring._dt;
            }

            LoadData();
        }
        public class Constring{
            public string constring = @"Data Source=.\SQLSERVER2014;Initial Catalog=PaymentDB;Integrated Security=True";
            public SqlConnection _sqlcon = new SqlConnection();
            public SqlCommand _sqlcmd = new SqlCommand();
            public SqlDataAdapter _sqlda = new SqlDataAdapter();
            public SqlDataReader dr;
            public DataTable _dt = new DataTable();

        }

        /// <summary>
        /// clear function will be passed here
        /// </summary>
        public void ClearAll()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Focus();
            lblID.Text = "";
        }

        //end of the clear function

        // start of the create function

        public void Create()
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("fill in all the rows", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO tblCustomer ( Name , Email , Address)  VALUES ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
                Constring _constring = new Constring();
                _constring._sqlcon = new SqlConnection(_constring.constring);
                _constring._sqlcon.Open();
                _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);

                int i = _constring._sqlcmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Customer saved", "Input status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Input status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            ClearAll();
        }
        //end of the create function

        //delete function

        public void Delete()
        {
            if (lblID.Text == "")
            {
                MessageBox.Show("no data", "status update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "DELETE  FROM tblCustomer WHERE CustomerID = '" + lblID.Text + "' ";

                Constring _constring = new Constring();
                _constring._sqlcon = new SqlConnection(_constring.constring);
                _constring._sqlcon.Open();
                _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);
                int i = _constring._sqlcmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Delete successful", "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Delete status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //end of the delete

        //load into dgview

        public void dgvLoad()
        {
            lblID.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
        }
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Yika().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadData();
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();
            LoadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            ClearAll();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            dgvLoad();
        }
    }
}
