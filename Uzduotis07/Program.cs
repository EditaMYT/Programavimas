using System;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui ivesti savo varda ir amziu. I ekrana isveskite: "Jusu vardas 
            {vardas}, o amzius {amzius)."
            */

            Console.WriteLine("Iveskite savo varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jusu vardas {vardas}, o amzius {amzius}.");
            Console.WriteLine();

            //Liepkite vartotojui ivesti bet koki simboli. Atspausdinkite 3x3 kvadrata is to simbolio.

            Console.WriteLine("Iveskite bet koki simboli");
            char simbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine();

            //Liepkite vartotojui ivesti bet koki skaiciu. Isveskite i ekrana sio skaiciaus kvadrata.
            
            Console.WriteLine("Iveskite bet koki skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}{skaicius}");
            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}{skaicius}");
            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}{skaicius}");
            Console.WriteLine();

            /*
            Liepkite vartotojui ivesti tris skaicius. Isveskite visu siu skaiciu suma nurodant
            atliekamus veiksmus ir siu skaiciu reiksmes ekrane. Pvz.: 5+3+8=16
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaitmuo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaitmuo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaitmuo3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Skaiciu suma: {skaitmuo1} + {skaitmuo2} + {skaitmuo3} = {skaitmuo1 + skaitmuo2 + skaitmuo3}");
            Console.WriteLine();
        }   
    }
}
