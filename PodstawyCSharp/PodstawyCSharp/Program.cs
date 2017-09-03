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

            do
            {
                Console.WriteLine("Podaj początek zakresu (minimum)");
            }
            while (!Int32.TryParse(Console.ReadLine(), out min));

            do
            {
                Console.WriteLine("Podaj koniec zakresu (maksimum)");
            }
            while (!Int32.TryParse(Console.ReadLine(), out max));

            if (min > max)
            {
                int temp;
                temp = min;
                min = max;
                max = temp;
            }

            int first = Numer.AddRandomNumber(min, max);
            int second = Numer.AddRandomNumber(min, max);
            Console.WriteLine("Wylosowałem " + first + " i " + second);
            Console.WriteLine("Suma dwóch losowych liczb z zakresu " + min + " - " + max + " jest równa " + (first + second));
            Console.ReadKey();
        }
    }
}
