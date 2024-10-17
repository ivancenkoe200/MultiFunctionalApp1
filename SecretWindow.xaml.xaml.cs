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

namespace MultiFunctionalApp_
{
    public partial class SecretWindow : Window
    {
        private string secretPassword = "Lizas"; // Укажите правильный пароль

        public SecretWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordInput.Password == secretPassword)
            {
                MessageText.Text = "Секретное сообщение: Ты молодец!";
            }
            else
            {
                MessageText.Text = "Неверный пароль. Попробуйте ещё раз.";
                PasswordInput.Clear();
            }
        }
    }
}