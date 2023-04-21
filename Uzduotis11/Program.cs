using System;

namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui ivesti tris skaicius, parasyti sia patikrinimo salyga,
            naudojant else if dalis:
            1. ar pirmas skaicius didesnis uz antra;
            2. ar antras skaicius didesnis uz trecia;
            3. ar trecias skaicius didesnis uz pirma;
            4. ar pirmi du skaiciai lygus.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (sk1 > sk2)
            {
                Console.WriteLine($"{sk1} didesnis uz {sk2}");
            }
            else if (sk2 > sk3)
            {
                Console.WriteLine($"{sk2} didesnis uz {sk3}");
            }
            else if (sk3 > sk1)
            {
                Console.WriteLine($"{sk3} didesnis uz {sk1}");
            }
            else if (sk1 == sk2)
            {
                Console.WriteLine($"{sk1} lygu {sk2}");
            }
            Console.WriteLine();

            /*
            Liepkite vartotojui ivesti sios dienos oro temperetura, atlikite siuos patikrinimus:
            1. ar temperatura <0 - isvesti "ziauriai salta";
            2. ar temperatura <10 - isvesti "labai salta";
            3. ar temperatura <20 - isvesti "salta";
            4. ar temperatura <30 - isvesti "normali temperatura";
            5. ar temperatura <40 - isvesti "karsta";
            6. ar temperatura >=40 - isvesti "visiskai degina";
            */

            Console.WriteLine("Irasykite sios dienos oro temperatura:");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (temperatura < 0)
            {
                Console.WriteLine("ziauriai salta");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("labai salta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("salta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("normali temperatura");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("karsta");
            }
            else
            {
                Console.WriteLine("visiskai degina");
            }
            Console.WriteLine();
        }
    }
}
