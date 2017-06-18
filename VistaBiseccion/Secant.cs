using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaBiseccion
{
    public partial class Secant : Form
    {
        public Secant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Roots.Secant secant = new Roots.Secant()
            {
                Expresion = textBox6.Text,
                ValStarta = Convert.ToDouble(textBox1.Text),
                ValStartb = Convert.ToDouble(textBox2.Text),
                Tolerance = Convert.ToDouble(textBox3.Text),
                Iteration = Convert.ToInt32(textBox4.Text)
            };
            LinkedList<string[]> Resultado = secant.solucion();

            foreach (var item in Resultado)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
