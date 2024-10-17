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
    public partial class RangeWindow : Window
    {
        public RangeWindow()
        {
            InitializeComponent();
        }

        private void CheckRangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(NumberInput.Text, out double number))
            {
                if (number >= 0 && number <= 14)
                {
                    RangeResult.Content = "Число попадает в диапазон [0 - 14].";
                }
                else if (number >= 15 && number <= 35)
                {
                    RangeResult.Content = "Число попадает в диапазон [15 - 35].";
                }
                else if (number >= 36 && number <= 50)
                {
                    RangeResult.Content = "Число попадает в диапазон [36 - 50].";
                }
                else if (number >= 51 && number <= 100)
                {
                    RangeResult.Content = "Число попадает в диапазон [51 - 100].";
                }
                else
                {
                    RangeResult.Content = "Число не попадает в заданные диапазоны.";
                }
            }
            else
            {
                RangeResult.Content = "Некорректный ввод. Пожалуйста, введите число.";
            }
        }
    }
}