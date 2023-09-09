using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_crud_implementation
{
    public partial class Marchant : Form
    {
        public Marchant()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Yika().Show();
            this.Hide();
        }
    }
}
