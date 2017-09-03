using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("Jak masz na imię?");
            imie = Console.ReadLine();

            int wiek;
            do
            {
                Console.WriteLine("Ile masz lat?");
            }
            while (!Int32.TryParse(Console.ReadLine(), out wiek));

            Console.WriteLine("Cześć " + imie + "! Fajnie, że masz " + wiek + " lat.");
            Console.ReadKey();
        }
    }
}
