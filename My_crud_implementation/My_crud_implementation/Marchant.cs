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
    public partial class Marchant : Form
    {
        public class Constring
        {
            public string constring = @"Data Source=.\SQLSERVER2014;Initial Catalog=PaymentDB;Integrated Security=True";
            public SqlConnection _sqlcon = new SqlConnection();
            public SqlCommand _sqlcmd = new SqlCommand();
            public SqlDataAdapter _sqlda = new SqlDataAdapter();
            public SqlDataReader dr;
            public DataTable _dt = new DataTable();

        }

        //beggining of the clear function

        void ClearAll()
        {
            txtAddress.Clear();
            txtName.Clear();
            txtEmail.Clear();
            lblID.Text = "";
            txtEmail.Focus();
        }
        //end of clear function
        //***begining of the create function

        void Create()
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("input Email", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtAddress.Text == "")
            {
                MessageBox.Show("input Address", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtName.Text == "")
            {
                MessageBox.Show("input Name", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtEmail.Text == "" || txtAddress.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("null parameters", "Input Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO tblMarchant (Name,Address,Email) VALUES ('" + txtName.Text +
                    "', '" + txtAddress.Text + "' ,'" + txtEmail.Text + "' )";

                Constring _constring = new Constring();
                _constring._sqlcon = new SqlConnection(_constring.constring);
                _constring._sqlcon.Open();
                _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);
                int i = _constring._sqlcmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("New marchant Saved", "Marchant Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Marchant Not Saved", "status update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearAll();
                LoadData();
            }
        }

        //**** end of the creat function

        //load daata

        object LoadData()
        {
            string query = "SELECT * FROM tblMarchant";
            Constring _constring = new Constring();
            _constring._sqlcon = new SqlConnection(_constring.constring);
            _constring._sqlcon.Open();
            _constring._sqlcmd = new SqlCommand(query, _constring._sqlcon);
            _constring._sqlda = new SqlDataAdapter(_constring._sqlcmd);
            _constring._dt = new DataTable();
            _constring._sqlda.Fill(_constring._dt);
            if (_constring._dt.Rows.Count > 0)
            {
                return dgvMarchant1.DataSource = _constring._dt;
            }
            else
            {
                _constring._dt = null;
                return _constring._dt;
            }

            LoadData();
        }
        //**configuring the dgv

        void dgvMarchant()
        {
            lblID.Text = dgvMarchant1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvMarchant1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dgvMarchant1.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvMarchant1.SelectedRows[0].Cells[3].Value.ToString();
        }

        //delete operation

        void Delete()
        {
            if (lblID.Text == "")
            {
                MessageBox.Show("no data", "status update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "DELETE  FROM tblMarchant WHERE MarchantID = '" + lblID.Text + "' ";

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
                LoadData();
                ClearAll();
            }
        }
        public Marchant()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Yika().Show();
            this.Hide();
        }

        private void Marchant_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dgvMarchant1_DoubleClick(object sender, EventArgs e)
        {
            dgvMarchant();
        }
    }
}
