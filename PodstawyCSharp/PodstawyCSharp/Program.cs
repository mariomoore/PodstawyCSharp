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
            int min, max;
            Console.WriteLine("Będziemy sumować dwie losowe liczby.");
            Console.WriteLine("Podaj początek zakresu (minimum)");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj koniec zakresu (maksimum)");
            max = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int first, second;
            first = rand.Next(min, max);
            second = rand.Next(min, max);
            Console.WriteLine("Wylosowałem " + first + " i " + second);
            Console.WriteLine("Suma dwóch losowych liczb z zakresu " + min + " - " + max + " jest równa " + (first + second));
            Console.ReadKey();
        }
    }
}
