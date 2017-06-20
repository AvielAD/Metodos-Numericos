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
    public partial class Falsa : Form
    {
        public Falsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots.FalsePosition fall = new Roots.FalsePosition()
            {
                Expresion = textBox1.Text,
                ValStarta = textBox3.Text,
                ValStartb = textBox4.Text,
                Tolerance = Convert.ToDouble(textBox2.Text),
                Iteration = Convert.ToInt32(textBox5.Text)
                
            };

            LinkedList<string[]> Resultado = fall.solucion();

            foreach (var item in Resultado)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2]);
            }
            
            textBox6.Text = fall.Root.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
