using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.Def_classes
{
    class Worker : Person
    {
        public float Salary { get; set; }

        public override void Tostring()
        {
            Console.WriteLine($"Name : {Name} \n " +
                $"Age : {Age} \n" +
                $"ID : {ID}\n" +
                $"Gender : {gender} \n" +
                $"Salary : {Salary} ");
        }
    }
}
