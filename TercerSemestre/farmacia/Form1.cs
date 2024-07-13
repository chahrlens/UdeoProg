using System;
using System.Windows.Forms;

namespace farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login w = new Login();
            w.ShowDialog();
        }

        private void atlaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProductos w = new AltaProductos();
            w.MdiParent = this;
            w.Show();
        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Existencias w = new Existencias();
            w.MdiParent = this;
            w.Show();
        }

        private void rangoFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rangos w = new Rangos();
            w.MdiParent = this;
            w.Show();
        }

        private void vencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vencimiento w = new Vencimiento();
            w.MdiParent = this;
            w.Show();
        }
    }
}
