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
    public partial class FixedPoint : Form
    {
        public FixedPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roots.FixedPoint fall = new Roots.FixedPoint()
            {
                Expresion = textBox1.Text,
                ValStarta = textBox3.Text,
                Tolerance = Convert.ToDouble(textBox2.Text),
                Iteration = Convert.ToInt32(textBox4.Text)

            };

            LinkedList<string[]> Resultado = fall.solucion();

            if (fall.Root != -1)
            {
                foreach (var item in Resultado)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                }
            }
            else
            {
                MessageBox.Show("No Converge", "Biseccion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            textBox5.Text = fall.Root.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
