using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Student
    {
       
       

        public String StudentID { get; set; }
        public String Name { get; set; }
        private static Student st;

        private Student() {}

        private Student(String id, String name)
        {
            StudentID = id;
            Name = name;
        }

        public static Student GetStudent()
        {
            if (st == null)
            {
                st = new Student();
            }
            return st;
        }
        public static Student GetStudent(string x, string y)
        {
            if (st == null)
            {
                st = new Student(x, y);
            }
            return st;
        }

    }
}
