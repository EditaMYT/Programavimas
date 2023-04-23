using System;
using System.Diagnostics.CodeAnalysis;

namespace Uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Įvesti du skaičius iš konsolės
            2. Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: sudėtis, atimtis,
            kėlimas 4 laipsniu sudėjus abu skaičius, kvadratinė šaknis sudėjus abu skaičius.
            3. Parašyti po atskirą metodą kiekvienam veiksmui (sudėčiai ir atimčiai naudoti int tipą,
            o visiems kitiems double).
            4. Su switch() patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti
            atitinkamą metodą, jei tokio case‘o nėra – informuoti vartotoją, jog tokio veiksmo nėra.
            */

            Console.WriteLine("Iveskite du skaicius:");
            string ivedimas = Console.ReadLine();
            int sk1 = Convert.ToInt32(ivedimas);
            ivedimas = Console.ReadLine();
            int sk2 = Convert.ToInt32(ivedimas);
            Sudetis(sk1, sk2);
            Atimtis(sk1, sk2);
            KelimasKetvirtuLaipsniu(sk1, sk2);
            KvadratineSaknis(sk1, sk2);

            Console.WriteLine("Koki veiksma norite atlikti?");
            Console.WriteLine("1 - sudetis");
            Console.WriteLine("2 - atimtis");
            Console.WriteLine("3 - kelimas 4 laipsniu sudejus abu skaicius");
            Console.WriteLine("4 - kvadratinė šaknis sudėjus abu skaičius");
            ivedimas = Console.ReadLine();
            Console.WriteLine(ivedimas);

            switch (ivedimas)
            {
                case 1:
                    int suma = Sudetis(sk1, sk2);
                    Console.WriteLine($"{sk1 + sk2}");
                    break;
                case 2:
                    int skirtumas = Atimtis(sk1, sk2);
                    Console.WriteLine($"{sk1 - sk2}");
                    break;
                case 3:
                    double rezultatas = KelimasKetvirtuLaipsniu(sk1, sk2);
                    Console.WriteLine(Math.Pow(sk1 + sk2, 4));
                    break;
                case 4:
                    double saknis = KvadratineSaknis(sk1, sk2);
                    Console.WriteLine(Math.Sqrt(sk1 + sk2));
                    break;
                default:
                    Console.WriteLine("Tokio veiksmo nera");
                    break;
            }
        }
        
        private static int Sudetis(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        private static int Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }

        private static double KelimasKetvirtuLaipsniu(int sk1, int sk2)
        {
            return Math.Pow(sk1 + sk2, 4);
        }

        private static double KvadratineSaknis(int sk1, int sk2)
        {
            return Math.Sqrt(sk1 + sk2);
        }
    }//Nerandu kaip panaikinti case atveju klaida (braukima)..  
}
