using MultiFunctionalApp_;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiFunctionalApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            var translatorWindow = new TranslatorWindow();
            translatorWindow.Show();
        }

        private void CalculatorButton_Click(object sender, RoutedEventArgs e)
        {
            var calculatorWindow = new CalculatorWindow();
            calculatorWindow.Show();
        }

        private void RangeButton_Click(object sender, RoutedEventArgs e)
        {
            var rangeWindow = new RangeWindow();
            rangeWindow.Show();
        }
        private void SecretButton_Click(object sender, RoutedEventArgs e)
        {
            var secretWindow = new SecretWindow();
            secretWindow.ShowDialog();
        }
    }
}