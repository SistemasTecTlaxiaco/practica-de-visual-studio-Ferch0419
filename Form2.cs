using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkealo_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formu1 = new Form1();
            formu1.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form formu3 = new Form3();
            formu3.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
    }
}
