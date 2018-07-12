using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Student : Person
    {
        public int Id { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
    }
}
