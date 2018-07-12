using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Repositories
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        IEnumerable<Faculty> GetFaculties();
        IEnumerable<Faculty> GetMathTeacher();
    }
}
