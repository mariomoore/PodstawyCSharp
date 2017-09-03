using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    class LogUser
    {
        private string usr;
        private string psd;
        private int mistakes = 0;

        public LogUser()
        {
            usr = "Mariusz";
            psd = "xyz";
        }

        public LogUser(string usr, string psd)
        {
            this.usr = usr;
            this.psd = psd;
            Console.WriteLine("Utworzono użytkownika " + this.usr);
        }

        public bool Logowanie()
        {
            while (!askForLogin())
            {
                Console.WriteLine("Nie ma takigo użytkownika");
            }

            while ((!askForPassword()) && mistakes < 4)
            {
                Console.WriteLine("Złe hasło");
                mistakes++;
            }

            if (mistakes >= 4)
            {
                Console.WriteLine("Za dużo prób logowania");
                return false;
            }
            else
            {
                Console.WriteLine("Próby błędnego logowania: " + mistakes);
                return true;
            }
        }

        private bool askForLogin()
        {
            string login;
            Console.WriteLine("Podaj login: ");
            login = Console.ReadLine();
            if (login == usr) return true;
            else return false;
        }

        private bool askForPassword()
        {
            string pass;
            Console.WriteLine("Podaj hasło: ");
            pass = Console.ReadLine();
            if (pass == psd) return true;
            else return false;
        }
    }
}
