using System;

namespace Uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. I ekrana isveskite kelis sunumeruotus pasirinkimus:
                a. 1 - stacionarus kompiuteris
                b. 2 - nesiojamas kompiuteris
                c. 3 - plansete
            2. Liepkite vartotojui ivesti pasirinkimo numeri
            3. Pagal ivesta numeri isveskite atitinkama teksta. Pvz.:
                a. stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
                b. nesiojamuoju kompiuteriu galite naudotis visur
                c. planseste galite naudotis visur
            4. Neradus tinkamo varianto, isvesti, kad tokio pasirinkimo nera.
            */

            switch (1)
            {
            case 1:
                    Console.WriteLine("1 - stacionarus kompiuteris");
                    break;
            }
            switch (2)
            {
            case 2:
                    Console.WriteLine("2 - nesiojamas kompiuteris");
                    break;
            }
            switch (3)
            {
            case 3:
                    Console.WriteLine("3 - plansete");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Iveskite pasirinkimo numeri:");
            int numeris = Convert.ToInt32(Console.ReadLine());

            switch (numeris)
            {
            case 1:
                Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                break;
            case 2:
                Console.WriteLine("Nesiojamuoju kompiuteriu galite naudotis visur");
                break;
            case 3:
                Console.WriteLine("Planseste galite naudotis visur");
                break;
            default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                 break;
            }
            Console.WriteLine();
        }
    }
}
