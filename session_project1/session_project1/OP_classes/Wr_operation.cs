using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace session_project1.OP_classes
{
    /// <summary>
    /// override (>) ?????????????????????????????????????????????????????????????????
    /// </summary>
    class Wr_operation
    {
        public void sort_worker (List<Person> Wor)
        {
            Person PW = new Person();
            Worker w = PW as Worker;
           for (int i = 0; i < Wor.Count; i++)
           {
                Person p1 = Wor[i];
                if (p1 is Worker)
                {
                    double Sal1 = (p1 as Worker).Salary;
                    for (int j = 0; j < Wor.Count; j++)
                    {
                        Person p2 = Wor[j];
                        if (p2 is Worker)
                        {
                            double Sal2 = (p2 as Worker).Salary;
                            
                            if (Sal1 < Sal2)
                            {
                                PW = p1;
                                p1 = p2;
                                p2 = PW;
                            }
                        }  
                    }
                    
                }
               
           }

           for(int i = 0; i < 3; i++ )
            {
                Person pw = new Person();
                if(pw is Worker)
                {
                    Worker W = pw as Worker;
                    W.ToString();
                }
            }
        }

       
    }
   
}
