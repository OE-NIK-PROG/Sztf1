using System;

namespace Labor1_a_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. FELADAT

            // Konzolra kiírás
            Console.Write("Hello World! \n");
            Console.WriteLine("Hello World Again!");

            #endregion

            #region 2. FELADAT

            // Kérjünk be valamit a felhasználótól és irjuk is ki azt
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine($"Hello '{name}'");

            #endregion

            #region 3. FELADAT

            // Kérjünk be egy számot, majd szorozzuk be egy a felhasználótól bekért számmal

            Console.Write("Number 1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number1 * number2}");
            #endregion

            #region 4. FELADAT

            // stringgé alakítása / Parse-olás / kasztolás

            // string
            string x = number1.ToString();

            // int
            string y = "4";
            int z = int.Parse(y);

            // kasztolas
            int valtozo = 255; // byte: 0-255
            byte masikValtozo = (byte)valtozo;

            #endregion

            #region 5. FELADAT

            /*
            Téglalap a és b oldalát bekérni, eltárolni egy-egy változóban
            majd a területét és kerületét kiszámolni és kiírni a következő formában:
            "Kerület={változó} [tabulátor] terület={változó}."
            */

            Console.WriteLine("Add meg az 'a' oldalt.");
            int aOldal = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 'b' oldalt.");
            int bOldal = int.Parse(Console.ReadLine());

            // kerület: (a+b)*2
            int kerulet = (aOldal + bOldal) * 2; // figyeljünk itt is a matematikailag helyes zárójelezésre!

            // terület: a*b
            int terulet = aOldal * bOldal;

            Console.WriteLine("Kerület={" + kerulet + "} \t Terület={" + terulet + "}");
            #endregion

            Console.ReadKey();
        }
    }
}
