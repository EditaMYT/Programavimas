using System;

namespace Uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Įvesti du skaičius iš konsolės
            2. Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
            3. Parašyti po atskirą metodą kiekvienam veiksmui (daugybai naudoti int tipą, o dalybai
            double)
            4. Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio 
            veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.
            */

            Console.WriteLine("Iveskite du skaicius:");
            string ivedimas = Console.ReadLine();
            int sk1 = Convert.ToInt32(ivedimas);
            ivedimas = Console.ReadLine();
            int sk2 = Convert.ToInt32(ivedimas);
            Console.WriteLine("Koki veiksma norite atlikti: daugyba ar dalyba?");
            ivedimas = Console.ReadLine();
            int daugyba = Convert.ToInt32(ivedimas);
            double dalyba = Convert.ToDouble(ivedimas);

            if (ivedimas == "daugyba")
            {
                Console.WriteLine($"Sandauga: {Daugyba(sk1, sk2)}");
            }

            else if (ivedimas == "dalyba")
            {
                Console.WriteLine($"Dalyba: {Dalyba(sk1, sk2)}");
            }
            else
            {
                Console.WriteLine($"Veiksmo {ivedimas} nera");
            }
        }

        private static int Daugyba(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        private static double Dalyba(int sk1, int sk2)
        {
            return (double)sk1 / sk2;
        }
    }//Nerandu kodel programa lusta..
}
