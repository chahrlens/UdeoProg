using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(this.inputText);
            this.inputText.KeyPress += new KeyPressEventHandler(inputText_Click);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.labelError.Text = "";
            if (this.inputText.Text.Length > 0 && this.listBox1.Items.Count < 15)
            {
                String str = this.inputText.Text;
                int value;
                if (int.TryParse(str, out value))
                {
                    this.listBox1.Items.Add(value);
                } else
                {
                    this.labelError.Text = "Debe ingresar un numero entero";
                }
                this.inputText.ResetText();
                this.inputText.Focus();

               
            } else if (this.inputText.Text.Length == 0)
            {
                this.labelError.Text = "Ingrese un nuemero entero";
            } 
            else
            {
                this.labelError.Text = "Capacidad maxima es 15";
            }
        }

        private void inputText_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.addButton.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < listBox1.Items.Count; i ++)
            {
                var element = listBox1.Items[i];
                int value = Convert.ToInt32(element.ToString());
                sum += value;
            }
            labelResult.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int pos = this.listBox1.SelectedIndex;
            if (pos > -1)
            {
                this.listBox1.Items.RemoveAt(pos);
            }
        }
    }
}
