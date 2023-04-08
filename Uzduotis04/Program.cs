using System;

namespace Uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Susikurkite reikamus kintamuosius uzduociai atlikti. I ekrana isvekite: 
            Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.
            Tarp {} nurodyti reikiami kintamieji, siose vietose ju reiksmes turi buti istatytos.
            */

            string marke = "Audi";
            string modelis = "A4";
            int metai = 2020;
            int rida = 20000;
            
            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.");
        }
    }
}
