using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_1
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Go = new Form1();
            Go.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 Go = new Form2();
            Go.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 Go = new Form3();
            Go.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Go = new Form5();
            Go.Show();
            this.Hide();
        }
    }
}
