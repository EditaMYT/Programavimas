using System;

namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Isveskite i ekrana dvieju skaiciu suma, skirtuma, sandauga ir dalmeni,
            kiekviena karta nurodant atliekama veiksma ir siu skaiciu reiksmes. Pvz.: 4+5=9 4-5=-1, ...
            */
            
            int pirmas = 3;
            int antras = 7;

            Console.WriteLine($"Suma: {pirmas} + {antras} = {pirmas + antras}");
            Console.WriteLine($"Skirtumas:{pirmas} - {antras} = {pirmas - antras}");
            Console.WriteLine($"Sandauga: {pirmas} * {antras} = {pirmas * antras}");
            Console.WriteLine($"Dalmuo: {pirmas} / {antras} = {pirmas / antras}");
            Console.WriteLine();

            //Isveskite i ekrana pasirinkta skaiciu, jo kvadrata ir ji pakelta treciuoju laipsniu.
            
            int skaicius = 33;
            Console.WriteLine($"Skaicius: {skaicius}");
            Console.WriteLine($"Skaicius kvadratu: {skaicius}^2 = {skaicius * skaicius}");
            Console.WriteLine($"Skaicius treciuoju laipsniu: {skaicius}^3 = {skaicius * skaicius * skaicius}");
            //Console.WriteLine(Math.Pow(skaicius, 3));
            Console.WriteLine();

            //Isveskite i ekrana triju skaiciu sandauga.
            
            int skaitmuo1 = 2;
            int skaitmuo2 = 3;
            int skaitmuo3 = 4;
            int sandauga = skaitmuo1 * skaitmuo2 * skaitmuo3; 
            Console.WriteLine($"Triju skaiciu sandauga: {skaitmuo1} * {skaitmuo2} * {skaitmuo3} = {sandauga}");
            Console.WriteLine();
        }
    }
}
