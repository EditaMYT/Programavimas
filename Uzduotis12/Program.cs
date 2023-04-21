using System;

namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite ivesti tris skirtingus skaicius. Suraskite kuris is siu skaiciu yra didziausias.

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("Pirmas skaicius yra didziausias");
            }
            if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine("Antras skaicius yra didziausias");
            }
            if (sk3 > sk1 && sk3 > sk2)
            {
                Console.WriteLine("Trecias skaicius yra didziausias");
            }
            if (sk1 == sk2 && sk2 == sk3)
            {
                Console.WriteLine("Nenumatytas atvejis");
            }
            Console.WriteLine();

            /*
            Liepkite ivesti egzamino rezultata. Atlikite siuos patikrinimus:
            1. ar gautas rezultatas yra [8-10];
            2. ar gautas rezultatas yra [5-8];
            3. ar gautas rezultatas yra <5.
            */

            Console.WriteLine("Iveskite egzamino rezultata:");
            int pazymys = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (pazymys >= 8 && pazymys <= 10) 
            {
                Console.WriteLine("rezultatas yra [8-10]");
            }
            else if (pazymys >= 5 && pazymys < 8)
            {
                Console.WriteLine("rezultatas yra [5 - 8)");
            }
            else if (pazymys < 5 && pazymys >= 0)
            {
                Console.WriteLine("Neišlaikyta");
            }
            else
            {
                Console.WriteLine("Netinkamai įvestas rezultatas");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*
            Liepkite ivesti du skaicius. Patikrinkite (naudojant 4 atskirus if'us):
            1. ar pirmas skaicius yra didesnis uz antraji, arba yra lygus 0;
            2. ar antras skaicius yra didesnis uz pirmaji, arba yra lygus 5;
            3. ar pirmas skaicius yra didesnis uz antraji ir yra lygus 20;
            4. ar antras skaicius yra didesnis uz pirmaji ir yra mazesnis uz 100.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (pirmas > antras || pirmas == 0) 
            {
                Console.WriteLine("pirmas skaicius yra didesnis uz antraji, arba yra lygus 0");
            }
            if (antras > pirmas || antras == 5)
            {
                Console.WriteLine ("antras skaicius yra didesnis uz pirmaji, arba yra lygus 5");
            }
            if (pirmas > antras && pirmas == 20)
            {
                Console.WriteLine("pirmas skaicius yra didesnis uz antraji ir yra lygus 20");
            }
            if (antras > pirmas && antras < 100)
            {
                Console.WriteLine("antras skaicius yra didesnis uz pirmaji ir yra mazesnis uz 100");
            }
            Console.WriteLine();
        }
    }
}
