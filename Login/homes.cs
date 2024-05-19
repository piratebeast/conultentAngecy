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
    public partial class homes : Form
    {
        public homes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            university obj = new university();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            employee obj = new employee();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            embassy obj = new embassy();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            dashBoard obj = new dashBoard();
            obj.Show();
            this.Hide();
        }
    }
}
