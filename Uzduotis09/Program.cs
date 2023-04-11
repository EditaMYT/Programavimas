using System;

namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui ivesti savo amziu. Jei amzius yra 18 arba daugiau,
            tuomet i ekrana isveskite, kad "Jus galite balsuoti".
            */

            Console.WriteLine("Iveskite savo amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }
            Console.WriteLine();

            /*
            Liepkite vartotojui ivesti bet koki skaiciu. Parasykite sias atskiras if salygas:
            1. Patikrinti, ar skaicius neigiamas, jei taip - aprekti vartotoja;
            2. Patikrinti, ar skaicius teigiamas, jei taip - pasveikinti vartotoja;
            3. Patikrinti, ar skaicius lyginis, jei taip - isvesti "taip, skaicius yra lyginis";
            4. Patikriniti ar skaicius dalinasi is 4, jei taip - isvesti "taip, dalinasi is 4";
            5. Patikrinti ar skacius yra didesnis nei 10, jei taip, isvesti "taip, skaicius yra didesnis uz 10.
            */

            Console.WriteLine("Iveskite bet koki skaiciu:");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Blogai!");
            }
            if (skaicius >= 0)
            {
                Console.WriteLine("Sveikiname!");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Taip, skaicius yra lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Taip, skaicius dalijasi is 4");
            }
            if (skaicius > 10)
            {
                Console.WriteLine("Taip, skaicius yra didesnis uz 10");
            }
            Console.WriteLine();

            /*
            Liepkite vartotojui ivesti du savo pazymius, raskite siu pazymiu vidurki,
            patikrinkite ar vidurkis yra lygus arba didesnis uz 5, jei taip, isveskite "Valio!!!".
            */

            Console.WriteLine("Iveskite viena pazymi:");
            int pazymys1 = Convert.ToInt32(Console.ReadLine()); //arba
            //string ivedimas = Console.ReadLine();
            //int pazymys1 = Convert.ToInt32(ivedimas);
            Console.WriteLine("Iveskite antra pazymi:");
            int pazymys2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double vidurkis = (double) (pazymys1 + pazymys2) / 2;
            Console.Write($"Pazymiu vidurkis: {vidurkis}");
            Console.WriteLine();

            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!!!");
            }
            Console.WriteLine();
        }   
    }
}
