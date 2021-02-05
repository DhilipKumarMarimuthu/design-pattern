using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AnonymouseLambdaMethod
{
    public class LambdaCollectionEx
    {
        List<Student> studentList = new List<Student>() 
        {
            new Student(){ RollNumber = 1, Name = "Dhilip", LastName = "Kumar", Age = 40, IsActive = true, IsBookBorrowed = true },
            new Student(){ RollNumber = 1, Name = "Uma", LastName = "Mani", Age = 38, IsActive = false, IsBookBorrowed = true },
            new Student(){ RollNumber = 1, Name = "Rithu", LastName = "Dhilip", Age = 15, IsActive = true, IsBookBorrowed = false },
            new Student(){ RollNumber = 1, Name = "Pranav", LastName = "Dhilip", Age = 12, IsActive = true, IsBookBorrowed = true },
            new Student(){ RollNumber = 1, Name = "Pranesh", LastName = "Senthil", Age = 10, IsActive = false, IsBookBorrowed = false },
            new Student(){ RollNumber = 1, Name = "Saindhu", LastName = "Vimal", Age = 10, IsActive = true, IsBookBorrowed = true },
        };

        public void CheckStudentActivities()
        {
            //var studentObj = studentList.Find(IsStudentActive);
            //var studentObj = studentList.Find(delegate(Student student) { return student.IsActive; });
            var studentObj = studentList.Find(x =>  { return x.IsActive; });
            if (studentObj != null)
            {

            }
        }

        private static bool IsStudentActive(Student student)
        {
            return student.IsActive;
        }
    }
}
