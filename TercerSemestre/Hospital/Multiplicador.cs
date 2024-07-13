using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Multiplicador : Form
    {
        public Multiplicador()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            this.labelError.Text = "";

            if (this.boxNumber.Text.Length > 0)
            {
                String str = this.boxNumber.Text;
                int value;
                if (int.TryParse(str, out value))
                {
                   if (value > 0 && value < 11) {
                        calcTable(value);
                    } else { this.labelError.Text = "Numero debe estar entre 1 y 10"; }
                }
                else
                {
                    this.labelError.Text = "Debe ingresar un numero entero";
                }
                this.boxNumber.ResetText();
                this.boxNumber.Focus();


            }
            else if (this.boxNumber.Text.Length == 0)
            {
                this.labelError.Text = "Ingrese un nuemero entero";
            }
            else
            {
                this.labelError.Text = "Capacidad maxima es 15";
            }
        }
        private void calcTable(int n)
        {
            listBox.Items.Clear();
            for (int i = 1; i<= 10; i++)
            {
                int result;
                result = i * n;
                this.listBox.Items.Add(i + " x " + n + " = " + result);
            }
        }
    }
}
