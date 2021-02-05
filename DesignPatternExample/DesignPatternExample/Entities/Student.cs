using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public bool IsBookBorrowed { get; set; }

        public override string ToString()
        {
            return $"Student ID : { RollNumber}, Name : { Name}, Last Name : { LastName}, IsActive : { IsActive }";
        }
    }
}
