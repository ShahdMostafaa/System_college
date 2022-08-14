using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.OP_classes
{
    class Per_operations
    {
        public void Add (List <Person> new_person)
        {
            Console.Write("press " + "/n"+
                "(1) To add Student " +"/n"+
                "(2) To add Worker" +"/n"+
                "(3) To add Instructore : ");
            string press = Console.ReadLine();
            Console.WriteLine();

            Person person = new Person();
            Console.Write("Enter The Name : ");
            person.Name = Console.ReadLine();
            Console.Write("Enter The Age : ");
            string age = Console.ReadLine();
            person.Age = int.Parse(age);
            Console.Write("Enter The ID : ");
            string id = Console.ReadLine();
            person.ID = int.Parse(id);
            Console.Write(" "); ///////////////////////////gender
            

            if (press=="1")
            {
                Student st = person as Student;
                Console.Write("Enter The GPA : ");
                string gpa = Console.ReadLine();
                st.Gpa = float.Parse(gpa);
                new_person.Add(person);
            }
            if (press == "2")
            {
                Worker Wr = person as Worker;
                Console.Write("Enter The Salary : ");
                string salary = Console.ReadLine();
                Wr.Salary = float.Parse(salary);
                new_person.Add(person);
            }
            if (press == "3")
            {
                Instructor In = person as Instructor;
                Console.Write("Enter The Salary : ");
                string salary = Console.ReadLine();
                In.Salary = float.Parse(salary);
                new_person.Add(person);
            }


        }

        public void Search (List <Person> pr)
        {
            Console.Write("Enter the ID : ");
            string id = Console.ReadLine();
            int Id = int.Parse(id);
           for(int i = 0; i < pr.Count; i++)
            {
                Person p = pr[i];
                if (p.ID == Id)
                {
                    if (p is Student)
                    {
                        Student st = p as Student;
                        Console.WriteLine(p.ToString());
                        break;
                    }
                    if (p is Worker)
                    {
                        Worker Wr = p as Worker;
                        Console.WriteLine(p.ToString());
                        break;
                    }
                    if (p is Instructor)
                    {
                        Instructor In = p as Instructor;
                        Console.WriteLine(p.ToString());
                        break;
                    }
                }
                else
                    Console.WriteLine("Not Found");
            }
        }

        public void Delete (List<Person> Del_pr)
        {
            Console.Write("Enter the ID : ");
            string id = Console.ReadLine();
            int Id = int.Parse(id);
            for (int i = 0; i < Del_pr.Count; i++)
            {
                Person p = Del_pr[i];
                if (p.ID == Id)
                {
                    if (p is Student)
                    {
                        Student st = p as Student;
                        Del_pr.Remove(p);
                        break;
                    }
                    if (p is Worker)
                    {
                        Worker Wr = p as Worker;
                        Del_pr.Remove(p);
                        break;
                    }
                    if (p is Instructor)
                    {
                        Instructor In = p as Instructor;
                        Del_pr.Remove(p);
                        break;
                    }
                }
               
            }
        }

    }

     class list_Sort : IComparable <Person> 
    {
        public int Compare(Person p1 , Person p2)
        {

        }

        int IComparable<Person>.CompareTo(Person other)
        {
            throw new NotImplementedException();
        }
    }
}
