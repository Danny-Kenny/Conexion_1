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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Login login = new Login();
        private void button_Person1_Click(object sender, EventArgs e)
        {
            if (login.login(textBox1.Text, textBox2.Text))
            {
                Form4 Iniciado = new Form4();
                Iniciado.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void button_Person2_Click(object sender, EventArgs e)
        {
            Form7 Registro = new Form7();
            Registro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 Inicio = new Form5();
            Inicio.Show();
            this.Hide();
        }
    }
}
