using System;

namespace Labor02_operator_if_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operatorok

            int a = 10;
            int b = 30;

            // ------------
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);

            #endregion

            #region Összeadás

            int c = a + b;

            #endregion

            #region  Egybevont összeadás

            int e = 0;
            e += a; // e = e + a;

            #endregion

            #region Szorzás

            c = a * b;

            #endregion

            // osztás
            c = a / b;
            c = 0;

            // érték növelése 1-gyel
            c++;
            ++c; // if(++c == 2)
            
            // érték csökkentése 1-gyel
            c--;
            --c;
            
            // modulós osztás
            int d = a % b;  // fekete fehér váltakozása



            Console.ReadLine();
        }
    }
}
