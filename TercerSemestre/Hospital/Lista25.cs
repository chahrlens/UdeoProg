using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Lista25 : Form
    {
        public Lista25()
        {
            InitializeComponent();
        }
        private  List<int> numeros = new List<int>();
        private void addButton_Click(object sender, EventArgs e)
        {
            this.labelError.Text = "";

            if (this.boxNumber.Text.Length > 0 && numeros.Count < 25)
            {
                String str = this.boxNumber.Text;
                int value;
                if (int.TryParse(str, out value))
                {
                    numeros.Add(value);
                    this.listBox.Items.Add(value);
                    recalcData();
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
                this.labelError.Text = "Capacidad maxima es 25";
            }
        }

        private void recalcData()
        {
            calcPositive();
            calcNegative();
            calcNotPair();
            calcPair();
            calcMajor50();
        }

        private void calcPositive()
        {
            int nPositive = 0;
           foreach(var element in numeros)
            {
                if (element > 0)
                {
                    nPositive++;
                }
                this.boxPositive.Text = nPositive.ToString();
           }
        }

        private void calcNegative()
        {
            int negatives = 0;
            foreach (var element in numeros)
            {
                if (element < 0)
                {
                    negatives++;
                }

            }
            this.boxNegatives.Text = negatives.ToString();
        }

        private void calcNotPair()
        {
            int n = 0;
            foreach (int element in numeros)
            {
                if (element % 2 != 0) { 
                    n++;
                }
            }
            this.boxNotPair.Text = n.ToString();
        }

        private void calcPair()
        {
            int n = 0;
            foreach (int element in numeros)
            {
                if (element % 2 == 0)
                {
                    n++;
                }

            }
            this.boxPair.Text = n.ToString();
        }

        private void calcMajor50 ( )
        {
            int n = 0;
            foreach (int element in numeros)
            {
                if (element > 50)
                {
                    n ++;
                }
            }
            this.boxMajorTan.Text = n.ToString();
        }
    }
}
