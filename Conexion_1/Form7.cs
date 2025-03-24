using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        Login login = new Login();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source = KENNY\\DANIEL;Initial Catalog = Altas; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select Nombre_Rol from Roles", conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Nombre_Rol"].ToString());
            }
        }

        private void button_Person1_Click(object sender, EventArgs e)
        {
            if (login.Registrar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text))
            {
                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }

            Form6 Login = new Form6();
            Login.Show();
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
