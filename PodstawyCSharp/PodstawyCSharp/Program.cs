using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Program
    {
        public enum Miesiąc
        {
            Styczeń = 1,
            Luty,
            Marzec,
            Kwiecień,
            Maj,
            Czerwiec,
            Lipiec,
            Sierpień,
            Wrzesień,
            Październik,
            Listopad,
            Grudzień,
        }

        public static void WypiszMiesiace()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Enum.GetName(typeof(Miesiąc), i));
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            WypiszMiesiace();
        }
    }
}
