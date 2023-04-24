using System;

namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raskite visu skaiciu nuo 1 iki 100 suma.

            int suma = 0;
            for (int i = 1; i < 101; i++)
            {
                suma += (i);
            }
            Console.WriteLine("Suma nuo 1 iki 100: " + suma);
            Console.WriteLine();

            //Raskite visu lyginiu skaiciu nuo 20 iki 40 suma.

            for (int i = 20; i < 41 && i % 2 == 0; i++)
            {
                suma += (i);
            }
            Console.WriteLine("Suma lyginiu skaiciu nuo 20 iki 40: " + suma);
            Console.WriteLine();

            //arba
            for (int i = 20; i < 41; i += 2)
            {
                suma += (i);
            }
            Console.WriteLine("Suma lyginiu skaiciu nuo 20 iki 40: " + suma);
            Console.WriteLine();
            // ir vistiek nesigauna!

            // Raskite visu nelyginiu skaiciu nuo 30 iki 60 suma.

            for (int i = 30; i < 61 && i % 2 != 0; i++)
            {
                suma += (i);
            }
            Console.WriteLine("Suma nelyginiu skaiciu nuo 30 iki 60: " + suma);
            Console.WriteLine();
            //Taip pat kaip ir su lyginiais nesigauna!

            /*
            Rasti visu skaiciu zemesniu uz 1000 ir didesniu uz 0 bei kurie dalinasi is
            3 arba 5 suma. Pvz.: visi skaiciai mazesni uz 10 ir kurie dalinasi is 3 arba 5
            yra: 3,5,6,9. Siu skaiciu suma yra 23.
            Turite gauti 233168 atsakyma.
            */

            for (int i = 1; i < 1000; i++)
            {
                suma += (i);
            }
            Console.WriteLine("Atsakymas: " + suma);
            Console.WriteLine();
            //Kur ir kaip rasyti dalyba is 3 ar 5?
        }
    }
}
