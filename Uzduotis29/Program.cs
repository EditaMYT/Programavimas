using System;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Parašykite metodą, kuris pasisveikintų su vartotoju.
            Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda
            formatuotai
            */

            Vardas();
            Amzius();
            HobioPavadinimas();
            string vardas = Console.ReadLine();
            int amzius = Convert.ToInt32(Console.ReadLine());
            string hobis = Console.ReadLine();

            Console.WriteLine($"Labas, {vardas} ({amzius}).");
            Console.WriteLine($"Jusu irasytas hobis: {hobis}.");
        }

        private static void Vardas()
        {
            Console.WriteLine("Jūsų vardas:");
            Console.ReadLine();
            Console.WriteLine();
        }

        private static void Amzius()
        {
            Console.WriteLine("Jūsų amzius:");
            Console.ReadLine();
            Console.WriteLine();
        }

        private static void HobioPavadinimas()
        {
            Console.WriteLine("Hobio pavadinimas:");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}