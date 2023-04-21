using System;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas " + "Edita");
            Console.WriteLine();

            int amzius = 26;
            Console.WriteLine("Ivestas amzius: {0}", amzius);
            Console.WriteLine();
            
            int skaicius = 25;
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine(skaicius);
            Console.WriteLine();

            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius} {skaicius}");
            Console.WriteLine();
        }
    }
}
