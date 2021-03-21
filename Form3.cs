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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnche_Click(object sender, EventArgs e)
        {
            Form formu1 = new Form1();
            formu1.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void btnTenis_Click(object sender, EventArgs e)
        {
            Form formu4 = new Form4();
            formu4.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formu4 = new Form4();
            formu4.Show();
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
    }
}
