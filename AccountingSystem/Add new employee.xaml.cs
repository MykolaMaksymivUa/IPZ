using AccountingSystem.Classes;
using AccountingSystem.DataAccess;
using NLog;
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
    /// Interaction logic for Add_new_employee.xaml
    /// </summary>
    public partial class Add_new_employee : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        public Add_new_employee()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
 
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            Close();
            //MessageBox.Show("Incorrect password");
        }
        private void AddNewEmpl(object sender, RoutedEventArgs e)
        {

            if (FirstNameBox.Text.Length == 0 || LastNameBox.Text.Length == 0 || StartDateBox.Text.Length == 0)
            {
                MessageBox.Show("Fill all fields!");

            }
            else
            {

                using (AccountingSystemContext repository = new AccountingSystemContext())
                {
                    repository.Employees.Add(new Employee(FirstNameBox.Text, LastNameBox.Text, StartDateBox.Text));

                    repository.SaveChanges();
                    logger.Info($"User [{FirstNameBox.Text}] [{LastNameBox.Text}] has been added!");
                }

                MainWindow main = new MainWindow();
                main.Show();
                Close();

            }
        }

    }
}
