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
    public partial class ejemplo : Form
    {
        public ejemplo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uno = Convert.ToInt32(this.textBox1.Text);
            int dos = Convert.ToInt32(this.textBox2.Text);
            this.label3.Text = Convert.ToString(uno+dos);
        }
    }
}
