using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1
{
    public class InformationDbContext : DbContext
    {
        public InformationDbContext()
           : base("name=InformationDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
