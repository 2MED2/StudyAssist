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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Meters", "Kilometers", "Inches", "Feet", "Grams", "Kilograms", "Pounds" });
            comboBox2.Items.AddRange(new string[] { "Meters", "Kilometers", "Inches", "Feet", "Grams", "Kilograms", "Pounds" });

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = double.Parse(textBox1.Text);
                string inputUnit = comboBox1.SelectedItem.ToString();
                string outputUnit = comboBox2.SelectedItem.ToString();
                double outputValue = ConvertUnits(inputValue, inputUnit, outputUnit);
                textBox2.Text = outputValue.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid value");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private double ConvertUnits(double value, string inputUnit, string outputUnit)
        {
            string[] lengthUnits = { "Meters", "Kilometers", "Inches", "Feet" };
            string[] weightUnits = { "Grams", "Kilograms", "Pounds" };

            bool isLengthConversion = Array.Exists(lengthUnits, unit => unit == inputUnit) && Array.Exists(lengthUnits, unit => unit == outputUnit);
            bool isWeightConversion = Array.Exists(weightUnits, unit => unit == inputUnit) && Array.Exists(weightUnits, unit => unit == outputUnit);

            if (!isLengthConversion && !isWeightConversion)
                throw new InvalidOperationException("Incompatible unit conversion.");

            double baseValue = value;

            if (isLengthConversion)
            {
                switch (inputUnit)
                {
                    case "Kilometers":
                        baseValue = value * 1000;
                        break;

                    case "Inches":
                        baseValue = value * 0.254;
                        break;

                    case "Feet":
                        baseValue = value * 0.3048;
                        break;

                    case "Meters":
                        baseValue = value;
                        break;
                }

                switch (outputUnit)
                {
                    case "Kilometers":
                        return baseValue / 1000;

                    case "Inches":
                        return baseValue / 0.254;

                    case "Feet":
                        return baseValue / 0.3048;

                    case "Meters":
                        return baseValue;
                }
            }
            else if (isWeightConversion)
            {
                switch (inputUnit)
                {
                    case "Kilograms":
                        baseValue = value * 1000;
                        break;
                    case "Pounds":
                        baseValue = value * 453.592;
                        break;
                    case "Grams":
                        baseValue = value;
                        break;
                }

                switch (outputUnit)
                {
                    case "Kilograms":
                        return baseValue / 1000;
                    case "Pounds":
                        return baseValue / 453.592;
                    case "Grams":
                        return baseValue;
                }
            }
            throw new InvalidOperationException("Conversion not supported.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This is a conversion calculator.\n" +
                "You can convert weight & length units.\n" +
                "Select the option relevant to you.",
                "What is Converter?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
