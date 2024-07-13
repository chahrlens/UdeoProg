namespace Clase2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        //Generte button
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox.Text != "")
            {
                int range;
                if (int.TryParse(textBox.Text, out range))
                {
                    clearData();
                    Random random = new Random();
                    for (int i = 0; i < range; i++)
                    {
                        int value1 = random.Next(-150, 150), value2 = random.Next(-150, 150);

                        listBox1.Items.Add(value1);
                        listBox2.Items.Add(value2);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox.Clear();
                }

            }
            else
            {
                MessageBox.Show("Ingrse una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //SumButton
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                clearLabels();
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    int sm = Convert.ToInt32(this.listBox1.Items[i]) + Convert.ToInt32(this.listBox2.Items[i]);
                    this.listBox3.Items.Add(sm.ToString());
                }
                recalcLabels();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subStractButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                clearLabels();
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    int sm = Convert.ToInt32(this.listBox1.Items[i]) - Convert.ToInt32(this.listBox2.Items[i]);
                    this.listBox3.Items.Add(sm.ToString());
                }
                recalcLabels();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void multiplierButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                clearLabels();
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    int sm = Convert.ToInt32(this.listBox1.Items[i]) * Convert.ToInt32(this.listBox2.Items[i]);
                    this.listBox3.Items.Add(sm.ToString());
                }
                recalcLabels();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dividerButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count > 0)
            {
                clearLabels();
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    int sm = 0, val1 = Convert.ToInt32(this.listBox1.Items[i]), val2 = Convert.ToInt32(this.listBox2.Items[i]);
                    if (val2 > 0)
                    {
                      sm = val1 / val2;
                    }
                    this.listBox3.Items.Add(sm.ToString());
                }
                recalcLabels();
            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearData()
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            clearLabels();
        }
        private void clearLabels()
        {
            this.listBox3.Items.Clear();
            this.boxAvgL1.Text = string.Empty;
            this.boxAvgL2.Text = string.Empty;
            this.boxAvgL3.Text = string.Empty;

            this.boxNegatives.Text = string.Empty;
            this.boxPositives.Text = string.Empty;
            this.boxNotPair.Text = string.Empty;
            this.boxPair.Text = string.Empty;
        }

        private void recalcLabels()
        {
            int negatives = 0, positives = 0, notPair = 0, pair = 0, avg1 = 0, avg2 = 0 , avg3 = 0, count = 0;
            for (int i = 0; i  < this.listBox1.Items.Count; i++)
            {
                count ++;
                int listA, listB, listC;
                listA = Convert.ToInt32(this.listBox1.Items[i]);
                listB = Convert.ToInt32(this.listBox2.Items[i]);
                listC = Convert.ToInt32((this.listBox3.Items[i]));

                avg1 += listA;
                avg2 += listB;
                avg3 += listC;


                // Find positive and negative
                if (listA < 0)
                {
                    negatives ++;
                } else if (listA > 0)
                {
                    positives ++;
                }

                if (listB < 0)
                {
                    negatives++;
                }
                else if (listB > 0)
                {
                    positives++;
                }

                if (listC < 0)
                {
                    negatives++;
                }
                else if (listC > 0)
                {
                    positives++;
                }

                //Find not pair and pair
                if (listA % 2 == 0)
                {
                    pair++;
                } else
                {
                    notPair++;
                }

                if (listB % 2 == 0)
                {
                    pair++;
                }
                else
                {
                    notPair++;
                }

                if (listC % 2 == 0)
                {
                    pair++;
                }
                else
                {
                    notPair++;
                }

            }

            //AVG
            avg1 = avg1 / count;
            avg2 = avg2 / count;
            avg3 = avg3 / count;

            boxAvgL1.Text = avg1.ToString();
            boxAvgL2.Text = avg2.ToString();
            boxAvgL3.Text = avg3.ToString();

            boxNegatives.Text = negatives.ToString();
            boxPositives.Text = positives.ToString();
            boxNotPair.Text = notPair.ToString();
            boxPair.Text = pair.ToString();
        }
    }
    
}
