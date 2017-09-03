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
            //Napisać program ktory sprawdza login i haslo uzytkownika do 5 nieudanych prob.
            LogUser user = new LogUser();
            if(user.Logowanie())
            {
                Console.WriteLine("Zalogowano");
            }
            else
            {
                Console.WriteLine("Nie udało się zalogować");
            }
            Console.WriteLine("Wciśnij klawisz");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Nowy użytkownik");
            LogUser otherUser = new LogUser("User", "Password");
            if (otherUser.Logowanie())
            {
                Console.WriteLine("Zalogowano");
            }
            else
            {
                Console.WriteLine("Nie udało się zalogować");
            }
            Console.WriteLine("Wciśnij klawisz");
            Console.ReadKey();
        }
    }
}
