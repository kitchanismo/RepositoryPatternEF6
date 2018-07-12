using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Repositories
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
       
        public FacultyRepository(InformationDbContext context)
            : base(context)
        {
        }

        public InformationDbContext InformationDbContext
        {
            get { return Context as InformationDbContext; }
        }

        public IEnumerable<Faculty> GetFaculties() => InformationDbContext.Set<Faculty>()
           .OrderBy(f => f.Age);

        public  IEnumerable<Faculty> GetMathTeacher() =>  InformationDbContext.Set<Faculty>()
           .Where(f => f.Subject == "math");
      
    }

}
