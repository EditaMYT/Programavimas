using System;

namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Isveskite pasirinkto skaiciaus daugybos lentele. Pvz.:
            5*0=0
            5*1=5
            */

            int skaicius1 = 5;
            int skaicius2 = 0;
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2++}");
            Console.WriteLine();

            /*
            Susikurkite sveikojo skaiciaus kintamaji su dvizenklio skaiciaus reiksme. 
            Isveskite i ekrana sio skaiciaus skaitmenu sandauga.
            */

            int dvizenklisSkaitmuo = 22;
            int pirmas = dvizenklisSkaitmuo / 10;
            int antras = dvizenklisSkaitmuo % 10;
            Console.WriteLine($"Dvizenklio skaitmens 22 skaitmenu sandauga: {pirmas} * {antras} = {pirmas * antras}");
            Console.WriteLine();
        }
    }
}
