using System;

namespace Uzduotis15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Parasyti for, kuris isvestu kiekviena skaiciu pradedant nuo 0 ir baigiant 10.
            Kiekviena skaiciu isvesti skirtingoje eiluteje.
            */

            for (int i = 0; i < 11; i++) 
            {
            Console.WriteLine(i);
            }
            Console.WriteLine();

            /*
            Parasyti for, kuris isvestu kas antra skaiciu pradedant 0 ir baigiant 15.
            Kiekviena skaiciu isvesti toje pacioje eiluteje, po kiekvieno skaiciaus dedant
            tarpa.
            */

            for (int i = 0; i < 16; i++) 
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();

            /*
            Parasyti for, kuris isvestu kas trecia skaiciu, pradedant 1 ir baigiant 20.
            Kiekviena skaiciu isvesti toje pacioje eiluteje, taciau parasant skaiciu 
            lauztiniuose skliaustuose. Pvz.: [1][4][7]...
            */

            for (int i = 1; i < 21; i++) 
            {
                Console.Write($"[{i}]");
                i++;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();

            /*
            Parasyti for, kuris eitu pro kiekviena skaiciu nuo 1 iki 10. Jame apsirasyti 
            if salyga, kuri patikrintu ar dabartinis skaicius yra lyginis, jei taip - tai 
            si skaiciu isvesti.
            */

            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                }
            Console.WriteLine(++i);
            }
            Console.WriteLine();
        }  
    }
}
