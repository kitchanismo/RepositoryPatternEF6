using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Repositories;

namespace WpfApp1
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InformationDbContext _context;

        public UnitOfWork(InformationDbContext context)
        {
            _context = context;
            Students = new StudentRepository(_context);
            Faculties = new FacultyRepository(_context);
        }

        public IStudentRepository Students { get; private set; }
        public IFacultyRepository Faculties { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    
    }

    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        IFacultyRepository Faculties { get; }
        int Complete();
    }
}
