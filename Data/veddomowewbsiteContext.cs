using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using veddomowewbsite.Models;

namespace veddomowewbsite.Data
{
    public class veddomowewbsiteContext : DbContext
    {
        public veddomowewbsiteContext (DbContextOptions<veddomowewbsiteContext> options)
            : base(options)
        {
        }

        public DbSet<veddomowewbsite.Models.Employee> Employees { get; set; } = default!;
        public DbSet<veddomowewbsite.Models.Department> Departments { get; set; } = default!;
    }
}
