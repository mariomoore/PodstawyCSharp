using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class Numer
    {
        public static int AddRandomNumber(int min, int max)
        {
            Random rand = new Random();
            int number = rand.Next(min, max);
            return number;
        }
    }
}
