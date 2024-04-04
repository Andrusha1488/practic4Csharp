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

namespace Practos4C_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum CorrectAnswer
    {
        First,
        Second,
        Third
    }

    public class TestQuestion
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
    }

    public partial class MainWindow : Window
    {
        private const string authorizationCode = "secret";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string inputCode = CodeTextBox.Text;
            if (inputCode == authorizationCode)
            {
                AuthorizedWindow authorizedWindow = new AuthorizedWindow();
                authorizedWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid authorization code. Please try again.");
            }
        }
    }
}
