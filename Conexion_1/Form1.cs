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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 sql = new Class1();

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            textBox2.Text = Convert.ToString(fila.Cells[1].Value);
            textBox3.Text = Convert.ToString(fila.Cells[2].Value);
            textBox4.Text = Convert.ToString(fila.Cells[3].Value);
            textBox5.Text = Convert.ToString(fila.Cells[4].Value);
            textBox6.Text = Convert.ToString(fila.Cells[5].Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.Insertar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView1.DataSource = sql.MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se han podido insertar los datos");
            }
        }
    }
}
