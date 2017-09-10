using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PodstawyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobowy osobowy = new Osobowy();
            Sportowy sportowy = new Sportowy();

            ArrayList samochody = new ArrayList();

            samochody.Add(osobowy);
            samochody.Add(sportowy);

            foreach (Samochod auto in samochody)
            {
                auto.WypiszMarke();
                Console.Write(" ");
                auto.WypiszKolor();
                Console.Write(" ");
                auto.WypiszPojemnosc();
                Console.Write("\n\r");
            }

            Console.ReadKey();
        }
    }
}
