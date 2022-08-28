using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.Def_classes
{
    class Student : Person
    {

        public float Gpa { get; set; }
        public Department Specialize { get; set; }

        public override void Tostring()
        {
            Console.WriteLine($"Name : {Name} \n " +
                $"Age : {Age} \n" +
                $"ID : {ID}\n" +
                $"Gender : {gender} \n" +
                $"GPA : {Gpa} \n" +
                $"Department : {Specialize}");
        }
    }
}
