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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Lab3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name, pswd;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = Username.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (name == "admin" && pswd == "admin")
            {
                MessageBox.Show("Login Successful.");
            }
            else
            {
                MessageBox.Show("enter correct username or password");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Username.Clear();
            Password.Clear();
        }

        private void Username_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            pswd = Password.Text;
        }
    }
}
