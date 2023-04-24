using System;

namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Iveskite is konsoles su skaicius (stataus trikampio statiniu ilgius).
            Suraskite izambine ir ja isveskite i ekrana.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int kvadratuSuma = sk1 * sk1 + sk2 * sk2;

            Console.WriteLine(Math.Pow(sk1 * sk1 + sk2 * sk2, 0.5));
            //arba
            Console.WriteLine(Math.Sqrt(sk1 * sk1 + sk2 * sk2));
        }
    }
}
