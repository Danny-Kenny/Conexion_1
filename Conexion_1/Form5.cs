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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 Login = new Form6();
            Login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 Registro = new Form7();
            Registro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
