using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Classes
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string startWorkingDate)
        {
            FirstName = firstName;
            LastName = lastName;
            StartWorkingDate = startWorkingDate;

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StartWorkingDate { get; set; }

    }
}
