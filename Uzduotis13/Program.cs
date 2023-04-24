using System;

namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui ivesti tris skaicius. Su switch patikrinkite pirmaji skaiciu:
            1. ar jis yra lygus 1: isveskite visu triju skaiciu suma;
            2. ar jis yra lygus 2: isveskite pirmo ir trecio skaiciu skirtuma;
            3. ar jis yra lygus 3: isveskite antro ir trecio skaiciu sandauga
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (sk1)
            {
                case 1:
                Console.WriteLine($"Visu tirju skaiciu suma: {sk1 + sk2 + sk3}");
                break;
            }
            switch (sk2)
            {
                case 2:
                Console.WriteLine($"Pirmo ir trecio skaiciu skirtumas: {sk1 / sk3}");
                break;
            }
            switch (sk3)
            {
                case 3:
                    Console.WriteLine($"Antro ir trecio skaiciu sandauga: {sk2 * sk3}");
                    break;
            }
            Console.WriteLine();

            /*
            Liepkite vartotojui ivesti gyvuno rusi. Su switch patikrinkite:
            1. ar ivestas gyvunas yra suo;
            2. ar ivestas gyvunas yra kate;
            3. ar ivestas gyvunas yra ziurkenas.
            */

            Console.WriteLine("Iveskite gyvuno rusi:");
            string gyvunas = Convert.ToString(Console.ReadLine());

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("suo");
                    break;
            }
            switch (gyvunas)
            {
                case "kate":
                    Console.WriteLine("kate");
                    break;
            }
            switch (gyvunas)
            {
                case "ziurkenas":
                    Console.WriteLine("ziurkenas");
                    break;
            }
            Console.WriteLine();
        }
    }
}
