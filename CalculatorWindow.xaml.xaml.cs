using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultiFunctionalApp
{
    public partial class CalculatorWindow : Window
    {
        private double operand1 = 10; // Пример значения
        private double operand2 = 5;   // Пример значения

        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string sign = OperatorInput.Text;
            double result = 0;
            bool validOperation = true;

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        validOperation = false;
                        CalculationResult.Content = "Ошибка: деление на ноль.";
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
                default:
                    validOperation = false;
                    CalculationResult.Content = "Некорректный знак операции.";
                    break;
            }

            if (validOperation)
            {
                CalculationResult.Content = "Результат: " + result;
            }
        }
    }
}