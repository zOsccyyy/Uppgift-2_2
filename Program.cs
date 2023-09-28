using System;

namespace Uppgift_2_2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma?");
            string Alma = Console.ReadLine();
            int Längd_E = int.Parse(Elin);
            int Längd_A = int.Parse(Alma);
            int sum = Längd_E - Längd_A;
            Console.WriteLine("Elin hoppade " + sum + " meter längre än Alma");

            
        }
    }
}
