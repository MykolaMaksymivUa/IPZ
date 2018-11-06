using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingSystem.Classes;

namespace AccountingSystem.DataAccess
{
    public class AccountingSystemContext:DbContext
    {
        public AccountingSystemContext():base("DBConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccountingSystemContext>());
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<WorkHours> WorkHourses { get; set; }
    }
}
