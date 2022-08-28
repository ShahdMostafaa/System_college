using System;


namespace session_project1.Def_classes
{
    class Person : Abs_print
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }
        public Type gender { get; set; }

        public override void Tostring() {
            Console.WriteLine($"Name : {Name} \n " +
                $"Age : {Age} \n" +
                $"ID : {ID}\n" +
                $"Gender : {gender} "); 
        }
        
        
    }
    enum Department
    {
        Information_System = 1,
        computer_Science = 2,
        Information_Technology = 3,
        Multi_Media = 4
    }
    enum Type
    {
        Male = 0,
        Female = 1
    }
}
