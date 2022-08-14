using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.OP_classes
{
    class In_operation
    {
        public void print_Male (List <Person> Ins)
        {
            
            for (int i = 0; i < Ins.Count; i++)
            {
                Person pi = Ins[i];
                if(pi is Instructor)
                {
                    Instructor In = pi as Instructor;

                    if (In.gender == Type.Male)
                    {
                        pi.ToString();
                    }
                }
                
            }
               
        }
    }
}
