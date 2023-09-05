using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ClearAll()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Ronald" && txtPassword.Text == "Python123")
            {
                new Home().Show();
                this.Hide();
                MessageBox.Show("successful login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
