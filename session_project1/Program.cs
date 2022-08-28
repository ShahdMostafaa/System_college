using session_project1.Def_classes;
using session_project1.OP_classes;
using System;
using System.Collections.Generic;

namespace session_project1
{
    class Program 
    {
        static void Run(List <Person> person)
        {
            Per_operation operation = new Per_operation();
            Console.WriteLine(" Welcome to the System ;) ");
            Console.WriteLine();
            Console.WriteLine("Press : \n" +
                "1 Add person\n" +
                "2 Search for person\n" +
                "3 Delete Person\n" +
                "4 Sort any list : ");
            string option = Console.ReadLine();
            int Option = int.Parse(option);

            if(Option == 1)
            {
                operation.Add(person);
            }
            else if (Option == 2)
            {
                operation.Search(person);
            }
            else if (Option == 3)
            {
                operation.Delete(person);
            }
            
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
           
        }
    }
}






