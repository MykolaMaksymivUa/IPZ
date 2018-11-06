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

namespace AccountingSystem
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text.Length == 0)
            {
                MessageBox.Show("Fill all fields!");

            }
            else
            {
                if (LoginBox.Text == "Mykola" || LoginBox.Text == "Admin" || LoginBox.Text == "User")
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    Close();
                }
                else MessageBox.Show("Incorrect login!");

            }
        }
    }
}
