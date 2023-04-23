using System;

namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Leiskite vartotojui įvesti du sveikuosius skaičius į programą. Sukurkite ir panaudokite
            šiuos metodus:
            Suma;
            Skirtumas;
            Sandauga;
            Dalmuo;
            */

            Console.WriteLine("Iveskite du skaicius:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Suma (sk1,sk2);
            Skirtumas (sk1, sk2);
            Sandauga (sk1, sk2);
            Dalmuo (sk1, sk2);
        }

        private static void Suma (int sk1, int sk2)
        {
            Console.WriteLine($"{sk1} + {sk2} = {sk1 + sk2}");
        }

        private static void Skirtumas (int sk1, int sk2)
        {
            Console.WriteLine($"{sk1} - {sk2} = {sk1 - sk2}");
        }

        private static void Sandauga (int sk1, int sk2)
        {
            Console.WriteLine($"{sk1} * {sk2} = {sk1 * sk2}");
        }

        private static double Dalmuo (int sk1, int sk2)
        {
            Console.WriteLine($"{(double)sk1} / {sk2} = {sk1 / sk2}");
        }
    }//Nerandu kodel braukia ir kaip sutvarkyt Dalmuo..
}