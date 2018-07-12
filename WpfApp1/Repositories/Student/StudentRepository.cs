using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(InformationDbContext context)
          : base(context)
        {
        }

        public InformationDbContext InformationDbContext
        {
            get { return Context as InformationDbContext; }
        }
      
        public IEnumerable<int> GetStudentAge() => InformationDbContext.Students
            .Select(s=>s.Age);
     
    }
}
