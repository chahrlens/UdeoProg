using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.menuStrip.Enabled = false;
            //Aplicacion de callback fuente
            //https://stackoverflow.com/questions/12362992/c-sharp-how-to-deal-with-callback-function
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
            Login w = new Login(() => this.menuStrip.Enabled = true);
            w.ShowDialog();
        }

        private void lIstaDocotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicos w = new Medicos();
            w.MdiParent = this;
            w.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades w = new Especialidades();
            w.MdiParent = this;
            w.Show();
        }

        private void listaPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaciente w = new FormPaciente();
            w.MdiParent = this;
            w.Show();
        }

        private void ingresoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresos w = new FormIngresos();
            w.MdiParent = this;
            w.Show();
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiagnostico w = new FormDiagnostico();
            w.MdiParent = this;
            w.Show();
        }

        private void listaCamasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCamas w = new FormCamas();
            w.MdiParent = this;
            w.Show();
        }

        private void listaHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHabitaciones w = new FormHabitaciones();
            w.MdiParent = this;
            w.Show();
            
        }

        private void altaDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaPaciente w = new FormAltaPaciente();
            w.MdiParent = this;
            w.Show();

        }
    }
}
