using System;

namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui ivesti bet koki sveikaji skaiciu. Isveskite sio skaiciaus
             daugybos lentele nuo 1 iki 5. Pvz.: 2*1=2
            */

            Console.WriteLine("Iveskite bet koki sveikaji skaciu:");

            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);
            int daugiklis = 1;

            Console.WriteLine("Skaičiaus '{0}' daugybos lentelė:", skaicius);
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            /*Liepkite vartotojui ivesti tris skaicius. I ekrana isveskite siuos skaicius
            ir ju vidurki. Pvz.: ivestu skaciu 4,5,8 vidurkis: 5,7.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaitmuo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int skaitmuo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaitmuo3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ju vidurkis: {(double)(skaitmuo1 + skaitmuo2 + skaitmuo3) / 3}");
            Console.WriteLine();

            /*
            Liepkite ivesti tris skaicius. Isveskite ivestus skaicius, ju kvadratus, 
            juos pakeltus treciuoju laipsniu, taip pat tuos skaicius, padalintus is dvieju.
            */

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Pirmo skaiciaus kvadratas: ");
            Console.WriteLine(sk1 * sk1);
            Console.Write("Antro skaiciaus kvadratas: ");
            Console.WriteLine(sk2 * sk2);
            Console.Write("Trecio skaiciaus kvadratas: ");
            Console.WriteLine(sk3 * sk3);
            Console.WriteLine();

            Console.Write("Pirmas skaicius treciuoju laipsniu: ");
            Console.WriteLine(sk1 * sk1 * sk1);
            Console.Write("Antras skaicius treciuoju lapsniu: ");
            Console.WriteLine(sk2 * sk2 * sk2);
            Console.Write("Trecias skaicius treciuoju laipsniu: ");
            Console.WriteLine(sk3 * sk3 * sk3);
            Console.WriteLine();

            Console.Write("Pirmas skaicius padalintas is dvieju: ");
            Console.WriteLine((double)sk1 / 2);
            Console.Write("Antras skaicius padalintas is dvieju: ");
            Console.WriteLine((double)sk2 / 2);
            Console.Write("Trecias skaicius padalintas is dvieju: ");
            Console.WriteLine((double)sk3 / 2);
            Console.WriteLine();
        }
    }
}
