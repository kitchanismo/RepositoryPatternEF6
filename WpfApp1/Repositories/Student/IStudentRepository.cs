using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;


namespace WpfApp1.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
     
        IEnumerable<int> GetStudentAge();
        
    }
}
