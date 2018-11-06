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

namespace AccountingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            SignUp main = new SignUp();
            main.Show();
            Close();
        }
        private void AddWorkStatus(object sender, RoutedEventArgs e)
        {

            addWorkStatus main = new addWorkStatus();
            main.Show();
            Close();
        }
        private void Get_Work_Hours(object sender, RoutedEventArgs e)
        {

            WorkHoursStatus main = new WorkHoursStatus();
            main.Show();
            Close();
        }
        private void Get_Empl_List(object sender, RoutedEventArgs e)
        {

            EmployeeList main = new EmployeeList();
            main.Show();
            Close();
        }

        private void Add_Employee(object sender, RoutedEventArgs e)
        {

            Add_new_employee main = new Add_new_employee();
            main.Show();
            Close();
        }
    }
}
