using System;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Paprašyti įvesti vartotojo vardą.
            2. Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
            3. Išvesti šią frazę į konsolę.
            */

            Console.WriteLine("Iveskite savo varda:");
            Console.ReadLine();
            Console.WriteLine();
            string vardas = "Edita";
            Pasisveikinimas(vardas);
        }

        private static void Pasisveikinimas(string vardas)
        {
            Console.WriteLine($"Sveiki, {vardas}");
            Console.WriteLine();
        }
    }
}
