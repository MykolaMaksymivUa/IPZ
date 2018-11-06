using AccountingSystem.Classes;
using AccountingSystem.DataAccess;
using AccountingSystem.Enums;
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
    /// Interaction logic for addWorkStatus.xaml
    /// </summary>
    public partial class addWorkStatus : Window
    {
        private WorkHours currentWorkHours;
        public addWorkStatus()
        {
            InitializeComponent();
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private void AddWorkStatus(object sender, RoutedEventArgs e)
        {
            if (EmployeeIDBox.Text.Length == 0 || monthBox.Text.Length == 0 || yearBox.Text.Length == 0 || MaxHoursBox.Text.Length == 0 || ActualHoursBox.Text.Length == 0 || MaxSalaryBox.Text.Length == 0)
            {
                MessageBox.Show("Fill all fields!");

            }
            else
            {

                using (AccountingSystemContext repository = new AccountingSystemContext())
                {
                    Months currentMonth = (Months)Enum.Parse(typeof(Months), monthBox.Text);
                    int currentEmployeeId = Int32.Parse(EmployeeIDBox.Text);
                    int currentYear = Int32.Parse(yearBox.Text);
                    int currentMaxHours = Int32.Parse(MaxHoursBox.Text);
                    int currentMaxSalary = Int32.Parse(MaxSalaryBox.Text);
                    int currentActualHours = Int32.Parse(ActualHoursBox.Text);
                    var currentEmployee = repository.Employees.First(x => x.ID == currentEmployeeId);
                    currentWorkHours = new WorkHours(currentEmployee, currentMonth, currentYear, currentMaxHours, currentMaxSalary, currentActualHours);
                    repository.WorkHourses.Add(currentWorkHours);

                    repository.SaveChanges();

                }
                ActualSalaryBlock.Text = currentWorkHours.ActualSalary.ToString();

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
