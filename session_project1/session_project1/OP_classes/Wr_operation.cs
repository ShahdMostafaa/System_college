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
            List<Worker> worker = new List<Worker>();
            Worker temp = new Worker();
            for( int i = 0; i < Wor.Count; i++ )
            {
                if(Wor[i] is Worker)
                {
                    worker.Add((Worker)Wor[i]);
                }
            }
            for(int i = 0; i < worker.Count; i++)
            {
                for (int j = 0; j < worker.Count; j++)
                {
                    if (worker[i].Salary < worker[j].Salary)
                    {
                        temp = worker[i];
                        worker[i] = worker[j];
                        worker[j] = temp;
                    }
                }
            }
            for(int i = 0; i < 3; i++)
            {
                worker[i].ToString();
            }
        }

       
    }
   
}
