using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Repositories;
using WpfApp1.Model;

namespace WpfApp1
{
    partial class Program
    {
        readonly static UnitOfWork _unitOfWork = new UnitOfWork(new InformationDbContext());

        static void Main(string[] args)
        {
            DisplayStudents();
            FindFaculty();
            DisplayAge();
            //InsertFaculty();
            //GetMathTeacher();
           // FindFaculty();
            _unitOfWork.Dispose();
            Console.ReadKey();
        }

        static void DisplayStudents()
        {
            Console.WriteLine("\nstudents");
            var students = _unitOfWork.Students.Get();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} {student.Name}");
            }
        }

        static void FindFaculty()
        {
            Console.WriteLine("\nFind");
            var faculties = _unitOfWork.Faculties.Find(f => f.Name.Contains("mig") || f.Name.Contains("fgf"));
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"{faculty.Id} {faculty.Name}");
            }
        }

        static void DisplayAge()
        {
            Console.WriteLine("\nage");
            var ages = _unitOfWork.Students.GetStudentAge();
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }
        }

        static void GetMathTeacher()
        {
            Console.WriteLine("\nmath");
            var faculties = _unitOfWork.Faculties.GetMathTeacher();
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"{faculty.Id} {faculty.Name}");
            }
        }

        static void InsertFaculty()
        {
            Console.WriteLine("\ninsert");
            _unitOfWork.Faculties.AddRange(Faculties());
            int rowsAffected = _unitOfWork.Complete();
            Console.WriteLine(rowsAffected);
        }

        public static IEnumerable<Faculty> Faculties()
        {
            return new List<Faculty>
            {
                new Faculty {
                    Name = "gfg",
                    Age = 44,
                    Address = "tokyo",
                    Gender = "female",
                    Subject = "math"
                },
                new Faculty {
                    Name = "ghg",
                    Age = 44,
                    Address = "tokyo",
                    Gender = "female",
                    Subject = "science"
                },
                new Faculty {
                    Name = "dfd",
                    Age = 44,
                    Address = "fgfgyo",
                    Gender = "female",
                    Subject = "math"
                }
            };
        }

    }

}
