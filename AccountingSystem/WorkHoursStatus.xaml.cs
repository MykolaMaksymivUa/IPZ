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
    /// Interaction logic for WorkHoursStatus.xaml
    /// </summary>
    public partial class WorkHoursStatus : Window
    {
        public WorkHoursStatus()
        {
            InitializeComponent();
            using (AccountingSystemContext context = new AccountingSystemContext())
            {
                var objectList = context.WorkHourses.ToList();

                foreach (WorkHours obj in objectList)
                {
                    headerBlock.Text = " ID" + "\tEmployee ID" + "\tCurrennt Month" + "\t Year" + "\t Max hours per month" + "\t Actual hours per month" + "\t Max salary" + "\t Actual Salary" + "\n";
                    WorkHoursListBlock.Text += " " + obj.ID + "\t " + obj.EmployeeID + "\t" + obj.Month + "\t\t" + obj.Year + "\t\t" + obj.MaxHours + "\t\t" + obj.ActualHours + "\t\t" + obj.MaxSalary + "\t\t" + obj.ActualSalary +"\n";

                }

            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            Close();
            //MessageBox.Show("Incorrect password");
        }
    }
}
