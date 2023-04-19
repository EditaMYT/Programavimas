using System;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vardas();
            Amzius();
            HobioPavadinimas();
            Pasisveikinimas();
            string vardas = Console.ReadLine();
            int amzius = Convert.ToInt32(Console.ReadLine());
            string hobis = Console.ReadLine();
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

        private static string Pasisveikinimas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Labas, {vardas} ({amzius}).");
            Console.WriteLine($"Jusu irasytas hobis: {hobis}.");
        }
    }//Nerandu kaip parasyti paskutiniu eiluciu..
}