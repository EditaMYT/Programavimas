using System;

namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parasyti for cikla, kuris suskaiciuotu, kiek skaiciu intervale [0 - 1000) dalinasi is 16.

            Console.WriteLine("Skaiciai intervale [0 - 1000), kurie dalinasi is 16:");
            int i = 0;
            for (i = 0; i < 1000; i += 16)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            /*Liepkite vartotojui ivesti teigiama skaiciu. While ciklo viduje skaiciu kelkites vis
            didesniu laipsniu ir ji isveskite i ekrana, kol skaicius netaps didesnis uz 1500.
            */

            Console.WriteLine("Iveskite teigiama skaiciu: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                Console.WriteLine($"Skaicius kvadratu: {sk * sk}");
                Console.WriteLine($"Skaicius treciuoju laipsniu: {sk * sk * sk}");
                Console.WriteLine($"Skaicius ketvirtuoju laipsniu: {sk * sk * sk * sk}");
                break;
            }//Negerai...
        }
    }
}
