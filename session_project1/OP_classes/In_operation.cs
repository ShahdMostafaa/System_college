using session_project1.Def_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace session_project1.OP_classes
{
    class In_operation
    {
        public void print_Male (List <Person> PI)
        {
            Console.WriteLine("Ente The Gende -> pess :" +
                " (0) For Male : " +
                "(1) For Female : ");
            string read = Console.ReadLine();
            int Gender = int.Parse(read);

            List<Instructor> Ins = new List<Instructor>();
            for (int i = 0; i < PI.Count; i++)
            {
               if( PI[i] is Instructor)
               {
                    Ins.Add((Instructor)PI[i]);
               }
            }
            for(int i = 0 ; i < Ins.Count ; i++)
            {
                if((int)Ins[i].gender==Gender)
                {
                    Ins[i].ToString();
                }
            }
        }
    }
}
