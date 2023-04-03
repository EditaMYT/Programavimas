using System;

namespace Uzduotis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startLine = "---------------------";
            string emptyLine = "|                   |";
            string name = "Martynas";
            Console.WriteLine(startLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine("|    Mano vardas    |");
            Console.WriteLine("|      " + name + "     |");
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(startLine);
            Console.WriteLine();
        }
    }
}
