using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void promedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 w = new Form1();
            w.MdiParent = this;
            w.Show();
        }

        private void mayorOMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayorYMenor w = new MayorYMenor();
            w.MdiParent = this;
            w.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial w = new Factorial();
            w.MdiParent = this;
            w.Show();
        }

        private void multiplicadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multiplicador w = new Multiplicador();
            w.MdiParent = this;
            w.Show();
        }

        private void lista25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista25 w = new Lista25(); 
                w.MdiParent = this;
            w.Show();
        }
    }
}
