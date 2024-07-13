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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.labelError.Text = "";

            if (this.boxNumber.Text.Length > 0)
            {
                String str = this.boxNumber.Text;
                int value;
                if (int.TryParse(str, out value))
                {
                    calcFactorial(value);
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

        private void calcFactorial(int n)
        {
            this.listFactorial.Items.Clear();
            this.boxFactorial.Clear();
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                this.listFactorial.Items.Add(i + " x ");
            }
            this.boxFactorial.Text = factorial.ToString();
        }

    }
}
