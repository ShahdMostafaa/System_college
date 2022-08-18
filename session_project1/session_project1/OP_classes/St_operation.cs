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
            List<Student> D_st = new List<Student>();
            Console.Write(" Press" +
                " 1 for Information System\n"+
                 " 2 for Computer Since \n"+
                " 3 for Information Technology \n" +
                "  4 for Multi Media : ") ;
            string input = Console.ReadLine();
            int DP_input = int.Parse(input);
            for (int i = 0; i < ds.Count; i++)
            {
               if(ds[i] is Student)
               {
                    D_st.Add((Student)ds[i]);
               }
            }
            for(int i = 0; i < D_st.Count; i++)
            {
                if ((int)D_st[i].Specialize == DP_input )
                {
                    D_st[i].ToString();
                }
            }
        }

        public void displayTop_3 (List<Person> top)
        {
            List<Student> student = new List<Student>();
            Student temp = new Student();
            for (int i = 0; i < top.Count; i++)
            {
                if (top[i] is Student)
                {
                    student.Add((Student)top[i]);
                }
            }
            for (int i = 0; i < student.Count; i++)
            {
                for (int j = 0; j < student.Count; j++)
                {
                    if (student[i].Gpa < student[j].Gpa)
                    {
                        temp = student[i];
                        student[i] = student[j];
                        student[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                student[i].ToString();
            }
        }
    }

}
