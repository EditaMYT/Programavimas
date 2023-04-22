using System;

namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Parasykite sumos funkcija su 3 parametrais, kuris grazina int tipo atsakyma.
            2. Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo atsakymą.
            3. Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
            */

            Console.WriteLine(Suma(1, 2, 3));
            Console.WriteLine(Dalmuo(7, 3));
            Console.WriteLine();
        }
        
        private static int Suma(int sk1, int sk2, int sk3)
        {
            return (sk1 + sk2 + sk3);
        }

        private static double Dalmuo(int sk1, int sk2)
        {
            return (double)sk1 / sk2;
        }
    }   
}
