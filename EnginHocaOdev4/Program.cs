using System;

namespace EnginHocaOdev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("joker");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)

            {
                Console.WriteLine(isim);
            }


            Console.WriteLine("Kaşık Yok");
        }
    }
}
