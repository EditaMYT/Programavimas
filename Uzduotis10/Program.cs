using System;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite ivesti skaiciu. 
            1. Jei skaicius lyginis, tuomet isveskite si skaiciu bei jo penkta laipsni.
            2. Jei skaicius nesidalina is 4, tuomet liepkite ivesti antraji skaciu. Isveskite
            abieju skaiciu suma ir sandauga.
            */

            Console.WriteLine("Iveskite skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 % 2 == 0)
            {
                Console.WriteLine($"Skaicius: {sk1}, pakeltas penktuoju laipsniu: {Math.Pow(sk1,5)}.");
            }

            if (sk1 % 4 != 0)
            {
                Console.WriteLine("Iveskite antraji skaiciu:");
                int sk2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Skaiciu suma: {sk1} + {sk2} = {sk1 + sk2}");
                Console.WriteLine($"Skaiciu sandauga: {sk1} * {sk2} = {sk1 * sk2}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}