using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Roots;
namespace VistaBiseccion
{
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots.Biseccion biseccion = new Roots.Biseccion() {
                Expresion = this.textBox6.Text,
                ValStarta = Convert.ToDouble(this.textBox1.Text),
                ValStartb = Convert.ToDouble(this.textBox2.Text),
                Tolerance = Convert.ToDouble(this.textBox3.Text),
                Iteration = Convert.ToInt32(this.textBox4.Text)
            };
            LinkedList< string[] > Resultado = biseccion.solucion();

            this.textBox5.Text = biseccion.Root.ToString();

            if (biseccion.Root != -1)
            {
                foreach (var item in Resultado)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
                }
            }
            else
            {
                MessageBox.Show("No se detectaron signos distintos para continuar", "Biseccion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
