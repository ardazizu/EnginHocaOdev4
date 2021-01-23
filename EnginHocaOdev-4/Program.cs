using System;

namespace EnginHocaOdev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionary <int,string> Students = new Mydictionary<int,string>();
            Students.Add(90, "Alex");

            Console.WriteLine(Students.Length);

            Students.Add(180, "De Souza");

            Console.WriteLine(Students.Length);

            
            

            

            Console.WriteLine("Beyaz Tavşanı Takip Et");
        }
    }
}
