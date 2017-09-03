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
            int wiek;
            string imie;
            Console.WriteLine("Jak masz na imię?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile masz lat?");
            wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cześć " + imie + "! Fajnie, że masz " + wiek + " lat.");
            Console.ReadKey();
        }
    }
}
