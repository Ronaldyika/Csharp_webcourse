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

namespace Phonebook
{
    public partial class Phonebook : Form
    {
        public Phonebook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string ConString = @"Data Source=.\SQLSERVER2014;Initial Catalog=PhonebookDB;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;

        DataTable dt = new DataTable();
        void ClearAll()
        {
            txtName.Clear();
            txtTell.Clear();
            txtEmail.Clear();
            txtSearch.Clear();
            txtAddress.Clear();
            txtName.Focus();
            txtName.Focus();
            lblID.Text = "";
        }
        private void Phonebook_Load(object sender, EventArgs e)
        {
            LoadData();
            ClearAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtTell.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Null parameters", "bad request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string query = "Insert into tblPhonebook(Name,Tell,Email,Address) Values('" + txtName.Text + "','" + txtTell.Text + "','" + txtEmail.Text +
                    "','" + txtAddress.Text + "')";
                con = new SqlConnection(ConString);
                con.Open();
                cmd = new SqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("saved successfull", "success info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("save failed", "failure information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearAll();
                LoadData();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                MessageBox.Show("null parrameters", "no such query", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "Delete From tblPhonebook Where PhonebookID = '" + lblID.Text + "'";
                con = new SqlConnection(ConString);
                con.Open();
                cmd = new SqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Delete successfull", "delete parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("delete failed", "del parametes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            ClearAll();
        }

        private void dgvPhonebook_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = dgvPhonebook.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvPhonebook.SelectedRows[0].Cells[1].Value.ToString();
            txtTell.Text = dgvPhonebook.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dgvPhonebook.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = dgvPhonebook.SelectedRows[0].Cells[4].Value.ToString();

        }
        object LoadData()
        {
            string query = "Select * From tblPhonebook";
            con = new SqlConnection(ConString);
            con.Open();
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dgvPhonebook.DataSource = dt;
            }
            else
            {
                dt = null;
                return dt;
            }

        }

        private void dgvPhonebook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                MessageBox.Show("null parrameters", "no such query", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "Update tblPhonebook set Name = '" + txtName.Text + "', Tell = '" + txtTell.Text + "', Email = '" + txtEmail.Text
                    + "', Address = '" + txtAddress.Text + "' Where PhonebookID = '" + lblID.Text + "'";
                con = new SqlConnection(ConString);
                con.Open();
                cmd = new SqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Update successfull", "Update parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed", "Update parametes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            ClearAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == ""){
                MessageBox.Show("null search","search ",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
            }
            else{
                string query = "Select * From tblPhonebook Where Name = '" + txtName.Text +"'";
                con = new SqlConnection(ConString);
                con.Open();
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvPhonebook.DataSource = dt;
                    MessageBox.Show("found search", "search ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    LoadData();
                    MessageBox.Show("search not found", "search ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
