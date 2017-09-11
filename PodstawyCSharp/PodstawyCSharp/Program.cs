using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    public static class BlackList
    {
        static string[] blackList = { "KACZOR", "PISIOR" };

        public static bool IsOnBlackList(this string word)
        {
            for (int i = 0; i < blackList.Length; i++)
            {
                if (word.ToUpper() == blackList[i]) return true;
            }
            return false;
        }
    }

    class Program
    {
        public static void BlackListTest()
        {
            string text = "Szedł raz stary kaczor przez wieś. 'Oj, nieładnie! Pisior na wierzchu!' - szeptały inne kaczki.";

            Console.WriteLine("Oryginał: ");
            Console.WriteLine(text);

            string[] words = text.Split(' ');

            Console.WriteLine("Po filtrowaniu: ");
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].IsOnBlackList())
                {
                    Console.Write(words[i]);
                    if (i < words.Length - 1) Console.Write(" ");
                }
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            BlackListTest();
        }
    }
}
