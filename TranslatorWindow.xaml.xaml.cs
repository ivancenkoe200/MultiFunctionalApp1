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
    public partial class TranslatorWindow : Window
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>
        {    
          { "солнечно", "sunny" },
          { "дождливо", "rainy" },    
          { "ветренно", "windy" },
          { "снежно", "snowy" },    
          { "облачно", "cloudy" },
          { "жарко", "hot" },   
          { "холодно", "coldly" },
          { "морозно", "frosty" },    
          { "засушливо", "arid" },
          { "туманно", "foggy" }
        };

        public TranslatorWindow()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputWord.Text.ToLower();
            if (dictionary.TryGetValue(input, out string translation))
            {
                TranslationResult.Content = "Перевод: " + translation;
            }
            else
            {
                TranslationResult.Content = "Такого слова нет.";
            }
        }
    }
}