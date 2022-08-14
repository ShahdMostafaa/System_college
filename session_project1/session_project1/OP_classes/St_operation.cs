using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.OP_classes
{
    class St_operation
    {
        public void Display (List <Person> ds )
        {
            Console.Write(" Press MM for Multi Media \n" +
                " IS for Information System\n" +
                " CS for Computer Since \n" +
                " IT for Information Technology : ");
            string DP_input = Console.ReadLine();

            if (DP_input == "MM" || DP_input == "mm")
            {
                department.Multi_Media.Equals(DP_input);
            }
            if (DP_input == "CS" || DP_input == "cs")
            {
                department.computer_Science.Equals(DP_input);
            }
            if (DP_input == "IS" || DP_input == "is")
            {
                department.Information_System.Equals(DP_input);
            }
            if (DP_input == "IT" || DP_input == "it")
            {
                department.Information_Technology.Equals(DP_input);
            }

            for (int i = 0; i < ds.Count; i++)
            {
                Person ps = ds[i];
                if (ps is Student)
                {
                    Student S = ps as Student;
                    if (S.Specialize == DP_input) /////////////////////////////////////////////////////////////////////////////////////
                    {
                        ds[i].ToString();
                    }
                }
                
            }
        }

        public void displayTop_3 (List<Person> top)
        {
            Person s = new Person();
            Student S = s as Student;
            for (int i = 0; i < top.Count ; i++)
            {
                Person p1 = top[i];
                if (p1 is Student)
                {
                    float gpa1 = (p1 as Student).Gpa;
                    for (int j = 0; j < top.Count; j++)
                    {
                        Person p2 = top[j];
                        if (p2 is Student)
                        {
                            float gpa2 = (p1 as Student).Gpa;
                            if(gpa1 < gpa2)
                            {
                                s = p1;
                                p1 = p2;
                                p2 = s;
                            }
                        }

                    }
                }
            }
            for (int i =0; i < top.Count; i++)
            {
                
            }
        }
    }

}
