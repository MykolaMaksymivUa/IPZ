using AccountingSystem.Classes;
using AccountingSystem.DataAccess;
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
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        public EmployeeList()
        {
            InitializeComponent();
            using (AccountingSystemContext context = new AccountingSystemContext())
            {
                var employeeList = context.Employees.ToList();

                foreach (Employee employee in employeeList)
                {
                    HeaderList.Text = " Employee ID" + "\tFirst name" + "\tLast Name" + "\t\tStart working date\n";
                    string info = $" {employee.ID,-20} \t{employee.LastName,-20} \t{employee.FirstName,-25} \t{employee.StartWorkingDate,-25}  \n";
                    EmpListBlock.Text += info;

                }

            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
