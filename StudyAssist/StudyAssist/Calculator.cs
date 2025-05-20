using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAssist
{
    public partial class Calculator : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = textBox1.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!textBox1.Text.Contains("."))
                        textBox1.Text = textBox1.Text + num.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + num.Text;
                }
            }
        }

        private void Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(textBox1.Text);
            op = num.Text;
            textBox1.Text = "";
        }

        private void eqlBtn_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(textBox1.Text);

            switch (op)
            {
                case "+":
                    textBox1.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    textBox1.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "*":
                    textBox1.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    textBox1.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                case "Mod":
                    textBox1.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;

                case "Exp":
                    double i = Convert.ToDouble(textBox1.Text);
                    double j;
                    j = enterSecondValue;
                    textBox1.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:
                    break;

            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            String f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1 * q);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589976323";
        }

        private void log_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(textBox1.Text);
            logg = Math.Log10(logg);
            textBox1.Text = Convert.ToString(logg);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(textBox1.Text);
            sqrt = Math.Sqrt(sqrt);
            textBox1.Text = Convert.ToString(sqrt);
        }

        private void sq_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(x);
        }

        private void cub_Click(object sender, EventArgs e)
        {
            double x, q, p, m;
            q = Convert.ToDouble(textBox1.Text);
            p = Convert.ToDouble(textBox1.Text);
            m = Convert.ToDouble(textBox1.Text);
            x = (q * p * m);
            textBox1.Text = Convert.ToString(x);
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(textBox1.Text);
            sinh = Math.Sinh(sinh);
            textBox1.Text = Convert.ToString(sinh);


        }

        private void sin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(textBox1.Text);
            sin = Math.Sin(sin);
            textBox1.Text = Convert.ToString(sin);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(textBox1.Text);
            cosh = Math.Cosh(cosh);
            textBox1.Text = Convert.ToString(cosh);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(textBox1.Text);
            cos = Math.Cos(cos);
            textBox1.Text = Convert.ToString(cos);
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(textBox1.Text);
            tanh = Math.Tanh(tanh);
            textBox1.Text = Convert.ToString(tanh);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(textBox1.Text);
            tan = Math.Tan(tan);
            textBox1.Text = Convert.ToString(tan);
        }

        private void frac_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(a);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(textBox1.Text);
            lnx = Math.Log(lnx);
            textBox1.Text = Convert.ToString(lnx);
        }

        private void perBten_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = Convert.ToString(a);
        }

        private void dec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(textBox1.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            textBox1.Text = Convert.ToString(i2);
        }

        private void bin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);
        }

        private void hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }

        private void oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
