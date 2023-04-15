using System;

namespace Uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tikslas:
            Suskaiciuoti, kiek duonos kepalu kepykla sugebes iskepti per diena;
            Patikrinit ar kepykla spes iskepti visus tos dienos uzsakymus, jei ne,
            suskaiciuoti kiek kepalu nespes iskepti;
            Suskaiciuoti kiek kepykla uzdirbs pelno is visu ta diena iskeptu kepalu.
            Is ankto zinoma informacija: darbo valandu per diena - 8 val.
            Vartotojo ivedama informacija:
            Kiek darbuotojas gali iskepti duonos kepalu per valanda;
            Kiek darbuotoju turi kepykla;
            Vieno kepalo savikaina;
            Vieno kepalo pardavimo kaina;
            Kiek kepykla turi ta diena iskepti kepalu (uzsakymai).
            */

            Console.WriteLine("Darbuotojas per valanda gali iskepti (kepalu):");
            Console.ReadLine();
            Console.WriteLine("Kiek kepykloje dirba darbuotoju:");
            Console.ReadLine();
            Console.WriteLine("Kokia vieno kepalo savikaina:");
            Console.ReadLine();
            Console.WriteLine("Kokia vieno kepalo pardavimo kaina:");
            Console.ReadLine();
            Console.WriteLine("Kiek kepykla per diena turi iskepti kepalu:");
            Console.ReadLine();

            int kepalas = Convert.ToInt32(Console.ReadLine());
            int valanda = Convert.ToInt32(Console.ReadLine());
            int darbuotojas = Convert.ToInt32(Console.ReadLine());
            int savikaina = Convert.ToInt32(Console.ReadLine());
            int kaina = Convert.ToInt32(Console.ReadLine());
            int uzsakymai = Convert.ToInt32(Console.ReadLine());

            

            }
        }
    }
}
