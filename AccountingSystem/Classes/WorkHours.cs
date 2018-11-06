using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingSystem.Enums;

namespace AccountingSystem.Classes
{
    public class WorkHours
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        public Months Month { get; set; }

        [Range(1998, 2020)]
        public int Year { get; set; }

        public int MaxHours { get; set; }

        public double MaxSalary { get; set; }

        public int ActualHours { get; set; }

        public double ActualSalary { get; set; }

        private const double Tax = 0.95;

        public WorkHours( Employee employee, Months month, int year, int maxHours, double maxSalary, int actualHours)
        {
            EmployeeID = employee.ID;
            Employee = employee;
            Month = month;
            Year = year;
            MaxHours = maxHours;
            MaxSalary = maxSalary;
            ActualHours = actualHours;
            ActualSalary = CalculateSalary();
        }

        public WorkHours()
        {
        }

        private double CalculateSalary() => MaxSalary * ((double)ActualHours/MaxHours)*Tax;
    }
}
