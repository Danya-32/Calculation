using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Work
{
    public partial class Form1 : Form
    {
        private double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Добавление цифр в TextBox
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TextBoxResult.Text += button.Text; // Добавляем значение кнопки в TextBox
        }

        // Добавление операций в TextBox
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            TextBoxResult.Text += " " + button.Text + " "; // Добавляем пробелы вокруг операции
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string input = TextBoxResult.Text;
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                MessageBox.Show("Please enter a valid expression (e.g., 1 + 2).");
                return;
            }

            if (double.TryParse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double firstNumber) &&
                double.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double secondNumber))
            {
                double result = 0;
                switch (parts[1])
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    case "%":
                        result = firstNumber % secondNumber;
                        break;
                    default:
                        MessageBox.Show("Invalid operation! Please use +, -, *, /, or %.");
                        return;
                }
                TextBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter valid numbers.");
            }
        }
    }
}
