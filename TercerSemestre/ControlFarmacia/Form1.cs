using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControlEducativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.menuStrip1.Enabled = false;
            //Aplicacion de callback fuente
            //https://stackoverflow.com/questions/12362992/c-sharp-how-to-deal-with-callback-function
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
            Login w = new Login(() => this.menuStrip1.Enabled = true);
            w.ShowDialog();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlProductos w = new ControlProductos();
            w.MdiParent = this;
            w.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Busquedas1 w = new Busquedas1();
            w.ShowDialog();

        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes1 w = new Reportes1();
            w.ShowDialog();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte2 w = new Reporte2();
            w.ShowDialog();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte3 w = new Reporte3();
            w.Show();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte4cs w = new Reporte4cs();
            w.ShowDialog();
        }

        private void reporete5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte5 w = new Reporte5();
            w.Show();
        }
    }
}
