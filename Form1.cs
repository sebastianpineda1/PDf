using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            PDF1.src = openFileDialog1.FileName;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox("Hola");
            me.close;
        }
    }
}
