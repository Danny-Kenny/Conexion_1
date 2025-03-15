using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conexion_1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Class2 sql = new Class2();

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            textBox2.Text = Convert.ToString(fila.Cells[1].Value);
            textBox3.Text = Convert.ToString(fila.Cells[2].Value);
            textBox4.Text = Convert.ToString(fila.Cells[3].Value);
            textBox5.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "") dataGridView1.DataSource = sql.Buscar(textBox5.Text);
            else dataGridView1.DataSource = sql.MostrarD();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarD();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
            {
                MessageBox.Show("Datos actualizados");
                dataGridView1.DataSource = sql.MostrarD();
            }
            else MessageBox.Show("No se han podido actualizar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sql.Insertar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
            {
                MessageBox.Show("Datos insertados");
                dataGridView1.DataSource = sql.MostrarD();
            }
            else MessageBox.Show("No se han insertado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(textBox1.Text))
            {
                MessageBox.Show("Datos eliminados");
                dataGridView1.DataSource = sql.MostrarD();
            }
            else MessageBox.Show("No se han eliminado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.Show();
            this.Hide();
        }
    }
}
