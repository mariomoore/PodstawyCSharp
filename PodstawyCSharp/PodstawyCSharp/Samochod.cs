using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    public abstract class Samochod
    {
        protected string kolor, marka, pojemnoscSilnika;
        public abstract void WypiszKolor();
        public abstract void WypiszMarke();
        public abstract void WypiszPojemnosc();
    }

    public class Osobowy : Samochod
    {
        public Osobowy()
        {
            kolor = "szary";
            marka = "opel";
            pojemnoscSilnika = "1.2l";
        }

        public override void WypiszKolor()
        {
            Console.Write("kolor " + kolor);
        }

        public override void WypiszMarke()
        {
            Console.Write("Zwykły " + marka);
        }

        public override void WypiszPojemnosc()
        {
            Console.Write("pojemnosc tylko " + pojemnoscSilnika);
        }
    }

    public class Sportowy : Samochod
    {
        public Sportowy()
        {
            kolor = "niebieski";
            marka = "subaru";
            pojemnoscSilnika = "2l";
        }

        public override void WypiszKolor()
        {
            Console.Write("kolor " + kolor);
        }

        public override void WypiszMarke()
        {
            Console.Write("Sportowy " + marka);
        }

        public override void WypiszPojemnosc()
        {
            Console.Write("spora pojemnosc " + pojemnoscSilnika);
        }
    }
}
