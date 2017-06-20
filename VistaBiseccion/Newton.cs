using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roots;

namespace VistaRoots
{
    public partial class Newton : Form
    {
        public Newton()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots.Newton newton = new Roots.Newton()
            {
                Expresion = textBox1.Text,
                Derivate = textBox2.Text,
                ValStarta = textBox3.Text,
                Iteration = Convert.ToInt32(textBox4.Text),
                Tolerance = Convert.ToDouble(textBox5.Text)
            };

            

            var resultado = newton.solucion();

            foreach(var item in resultado)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
            }

            textBox6.Text = Convert.ToString(newton.Root);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
