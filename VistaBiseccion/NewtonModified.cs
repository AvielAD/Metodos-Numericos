using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaRoots
{
    public partial class NewtonModified : Form
    {
        public NewtonModified()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots.NewtonM newton = new Roots.NewtonM()
            {
                Expresion = textBox1.Text,
                Tolerance = Convert.ToDouble(textBox2.Text),
                Derivate = textBox3.Text,
                DerivateTwo = textBox4.Text,
                ValStarta = textBox5.Text,
                Iteration = Convert.ToInt32(textBox6.Text),
            };
            
            var resultado = newton.solucion();

            foreach (var item in resultado)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }

            textBox7.Text = Convert.ToString(newton.Root);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
