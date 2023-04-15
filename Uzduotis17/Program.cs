using System;

namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui ivesti teigiama skaiciu. Ciklo pagalba si skaiciu 
            isvesti mazejimo tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1 0.
            Kiekviena karta isvesti skirtingose eilutese.
            */

            Console.WriteLine("Iveskite teigiama skaiciu:");
            Console.ReadLine();
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius > -1)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }
            Console.WriteLine();
            //Nesigauna..

            /*
            Liepkite vartotojui ivesti neigiama skaiciu. Ciklo pagalba si skaiciu
            isvesti didejimo tvarka iki kol jis pasieks 0, taip pat isvesti 0. 
            Pvz.: -4 -3 -2 -1 0. Kiekviena karta isvesti toje pacioje eiluteje,
            skaicius atskiriant tarpais.
            */

            Console.WriteLine("Iveskite neigiama skaiciu:");
            Console.ReadLine();
            skaicius = 0;
            while (skaicius < 1)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
            Console.WriteLine();
            //Nesigauna...

            /*
            Padarykite skaiciuotuva. Kiekvieno ciklo iteracijos metu vartotojas turi
            suvesti du skaicius. Is siu skaiciu turi buti grazinami sudeties, skirtumo,
            sandaugos ir dalmens atsakymai, isvedant kartu ir atliekamus veiksmus. Pvz.:
            5+4=9
            5-4=1
            Programa vykdoma tol, kol vartotojas nori atlikineti skaiciavimus.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu:");
            Console.ReadLine();

            int i = 0;
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int sk2 = Convert.ToInt32(Console.ReadLine());
            while (skaicius < 10)
            {
                Console.WriteLine($"{sk1} + {sk2} = {sk1 + sk2}");
                Console.WriteLine($"{sk1} - {sk2} = {sk1 - sk2}");
                Console.WriteLine($"{sk1} * {sk2} = {sk1 * sk2}");
                Console.WriteLine($"{sk1} / {sk2} = {sk1 / sk2}");
                skaicius++;
            }
            Console.WriteLine();
            //Nesigauna...
        }
    }
}
