using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF7.Models
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CompanyDbContext>());  
        }
        public DbSet<Department>Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}