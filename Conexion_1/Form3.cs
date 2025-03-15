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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Class3 sql = new Class3();

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            textBox2.Text = Convert.ToString(fila.Cells[1].Value);
            textBox3.Text = Convert.ToString(fila.Cells[2].Value);
            textBox4.Text = Convert.ToString(fila.Cells[3].Value);
            textBox5.Text = Convert.ToString(fila.Cells[4].Value);
            textBox6.Text = Convert.ToString(fila.Cells[5].Value);
            textBox7.Text = Convert.ToString(fila.Cells[6].Value);
            textBox8.Text = Convert.ToString(fila.Cells[7].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.Insertar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text))
            {
                MessageBox.Show("Registro insertado correctamente");
                dataGridView1.DataSource = sql.Aparecer();
            }
            else MessageBox.Show("Error al insertar registro");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.Aparecer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text))
            {
                MessageBox.Show("Registro actualizado correctamente");
                dataGridView1.DataSource = sql.Aparecer();
            }
            else MessageBox.Show("Error al actualizar registro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(textBox1.Text))
            {
                MessageBox.Show("Registro eliminado correctamente");
                dataGridView1.DataSource = sql.Aparecer();
            }
            else MessageBox.Show("Error al eliminar registro");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "") dataGridView1.DataSource = sql.Buscar(textBox9.Text);
            else dataGridView1.DataSource = sql.Aparecer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.Show();
            this.Hide();
        }
    }
}
