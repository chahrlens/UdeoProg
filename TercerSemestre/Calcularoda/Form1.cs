using System.Globalization;
namespace Calcularoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string inputValue = ".";
        private double outputValue = 0;
        private double productValue = 0;
        private bool usePoint = false;
        private string operation = "";


        private void showResult()
        {
            boxResult.Text = outputValue.ToString();
        }

        private void setOutPut()
        {
            if (double.TryParse(inputValue, CultureInfo.InvariantCulture, out double result))
            {
                outputValue = result;
            }
            showResult();
        }

        private void setOperation(string sing)
        {
            operation = sing;
            inputValue = ".";
            usePoint = false;
            productValue = outputValue;
            outputValue = 0;
        }


        private void AppendNumberToInputValue(string number)
        {
            if (usePoint)
            {
                inputValue += number;
            }
            else
            {
                int pointIndex = inputValue.IndexOf(".");
                inputValue = inputValue.Insert(pointIndex, number);
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            inputValue = ".";
            usePoint = false;
            outputValue = 0;
            boxResult.Text = "0.";
            operation = "";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("7");
            setOutPut();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            usePoint = true;
            if (!inputValue.Contains("."))
            {
                inputValue += ".";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("8");
            setOutPut();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("9");
            setOutPut();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("4");
            setOutPut();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("5");
            setOutPut();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("6");
            setOutPut();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("1");
            setOutPut();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("2");
            setOutPut();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("3");
            setOutPut();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendNumberToInputValue("0");
            setOutPut();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            setOperation("/");
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            setOperation("sqr");
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            setOperation("*");
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            setOperation("%");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            setOperation("-");
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            setOperation("1/x");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            setOperation("+");

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    {
                        outputValue += productValue;
                        showResult();
                        break;
                    }
                case "-":
                    {
                        outputValue -= productValue;
                        showResult();
                        break;
                    }
                case "*":
                    {
                        outputValue *= productValue;
                        showResult();
                        break;
                    }
                case "/":
                    {
                        outputValue /= productValue;
                        showResult();
                        break;
                    }
                case "sqr":
                    {
                        outputValue = Math.Sqrt(productValue);
                        showResult();
                        break;
                    }
                case "%":
                    {
                        outputValue %= productValue;
                        showResult();
                        break;
                    }
                case "1/x":
                    {
                        outputValue /= productValue;
                        showResult();
                        break;
                    }

            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            inputValue = ".";
            outputValue *= (-1);
            productValue = outputValue;
            setOutPut();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizado por Carlos Isidro Zepeda.\n C. 2301002056");
        }
    }
}
