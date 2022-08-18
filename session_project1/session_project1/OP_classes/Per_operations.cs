using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.OP_classes
{
    class Per_operations : Peson_iterface
    {
        public void Add (List <Person> new_person)
        {
            Console.Write("press \n " + 
                "(1) To add Student \n" +
                "(2) To add Worker \n" +
                "(3) To add Instructore : ");
            string press = Console.ReadLine();
            Console.WriteLine();

            ////////////////////////////////////////////////////////


            if (press=="1")
            {
                Person person = new Student();
                Student st = person as Student;

                Console.Write("Enter The Name : ");
                person.Name = Console.ReadLine();
                Console.Write("Enter The Age : ");
                string age = Console.ReadLine();
                person.Age = int.Parse(age);
                Console.Write("Enter The ID : ");
                string id = Console.ReadLine();
                person.ID = int.Parse(id);
                Console.Write("Press 0 for Male " +
                    "1 for Female : ");
                string Gender_input = Console.ReadLine();
                person.gender = (Type)int.Parse(Gender_input);

                Console.Write(" Press" +
               " 1 for Information System\n" +
                " 2 for Computer Since \n" +
               " 3 for Information Technology \n" +
               "  4 for Multi Media : ");
                string input = Console.ReadLine();
                st.Specialize = (Department)int.Parse(input);
                Console.Write("Enter The GPA : ");
                string gpa = Console.ReadLine();
                st.Gpa = float.Parse(gpa);
                new_person.Add(person);
            }
            if (press == "2")
            {
                Person person = new Worker();
                Worker Wr = person as Worker;

                Console.Write("Enter The Name : ");
                person.Name = Console.ReadLine();
                Console.Write("Enter The Age : ");
                string age = Console.ReadLine();
                person.Age = int.Parse(age);
                Console.Write("Enter The ID : ");
                string id = Console.ReadLine();
                person.ID = int.Parse(id);
                Console.Write("Press 0 for Male " +
                    "1 for Female : ");
                string Gender_input = Console.ReadLine();
                person.gender = (Type)int.Parse(Gender_input);

                Console.Write("Enter The Salary : ");
                string salary = Console.ReadLine();
                Wr.Salary = float.Parse(salary);
                new_person.Add(person);
            }
            if (press == "3")
            {
                Person person = new Instructor();
                Instructor In = person as Instructor;

                Console.Write("Enter The Name : ");
                person.Name = Console.ReadLine();
                Console.Write("Enter The Age : ");
                string age = Console.ReadLine();
                person.Age = int.Parse(age);
                Console.Write("Enter The ID : ");
                string id = Console.ReadLine();
                person.ID = int.Parse(id);
                Console.Write("Press 0 for Male " +
                    "1 for Female : ");
                string Gender_input = Console.ReadLine();
                person.gender = (Type)int.Parse(Gender_input);

                Console.Write(" Press" +
               " 1 for Information System\n" +
                " 2 for Computer Since \n" +
               " 3 for Information Technology \n" +
               "  4 for Multi Media : ");
                string input = Console.ReadLine();
                In.Specialize = (Department)int.Parse(input);
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
                if (pr[i].ID == Id)
                {
                    if (pr[i] is Student)
                    {
                        Student st = pr[i] as Student;
                        Console.WriteLine(st.ToString());
                        break;
                    }
                    if (pr[i] is Worker)
                    {
                        Worker Wr = pr[i] as Worker;
                        Console.WriteLine(pr[i].ToString());
                        break;
                    }
                    if (pr[i] is Instructor)
                    {
                        Instructor In = pr[i] as Instructor;
                        Console.WriteLine(In.ToString());
                        break;
                    }
                    else
                        Console.WriteLine("Not Found");
                } 
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
                if (Del_pr[i].ID == Id)
                {
                    if (Del_pr[i] is Student)
                    {
                        Student st = Del_pr[i] as Student;
                        Del_pr.Remove(st);
                        break;
                    }
                    if (Del_pr[i] is Worker)
                    {
                        Worker Wr = Del_pr[i] as Worker;
                        Del_pr.Remove(Wr);
                        break;
                    }
                    if (Del_pr[i] is Instructor)
                    {
                        Instructor In = Del_pr[i] as Instructor;
                        Del_pr.Remove(In);
                        break;
                    }
                }
               
            }
        }

    }

     class list_Sort : IComparable <Person> 
    {
        int IComparable<Person>.CompareTo(Person other)
        {
            throw new NotImplementedException();
        }
    }
}
