using System;
using System.Collections.Generic;

using System.Linq;

using System.Windows.Forms;

namespace Hospital
{
    public partial class MayorYMenor : Form
    {
        public MayorYMenor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.labelError.Text = "";
            if (this.boxNumber.Text.Length > 0 && this.listBox.Items.Count < 10)
            {
                String str = this.boxNumber.Text;
                int value;
                if (int.TryParse(str, out value))
                {
                    this.listBox.Items.Add(value);
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int min, max;

            List<int> list = new List<int>();
            for (int i = 0; i< this.listBox.Items.Count; i++)
            {
                list.Add(Convert.ToInt32(this.listBox.Items[i].ToString()));
            }
            min = list.Min<int>();
            max = list.Max<int>();
            this.boxMenor.Text = min.ToString();
            this.boxMayor.Text = max.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int pos = this.listBox.SelectedIndex;
            if ( pos > -1)
            {
                this.listBox.Items.RemoveAt(pos);
                this.boxNumber.Focus();
            }
        }
    }
}
