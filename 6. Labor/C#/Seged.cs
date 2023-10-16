using System;
using System.IO;

namespace Ismetlo_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringek egymás után fűzése
            string str1 = "Október";
            string str2 = "hónap";
            string str3 = "van";
            string str4 = str1 + " " + str2 + " " + str3;
            Console.WriteLine(str4);

            //Substring
            string sz1, sz2;
            sz1 = "Hello, World";
            sz2 = sz1.Substring(7, 5); // Kezdő index: 0
            Console.WriteLine(sz2);

            //Részsorozat keresése - IndexOf
            int sor;
            string s1;
            s1 = "Ez egy karaktersorozat";
            sor = s1.IndexOf("karakter");
            Console.WriteLine(sor);
            sor = s1.IndexOf("egy");
            Console.WriteLine(sor);
            sor = s1.IndexOf("ez nincs benne");
            Console.WriteLine(sor);

            //Kis- és nagybetűs formára alakítás
            int ev;
            string s;
            ev = 1982;
            s = "Lajos születési éve " + ev;
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());

            //Formázott megjelenítés
            string mi = "árvíztűrő tükörfúrógép";
            string milyen = "legjobb";
            int db = 123;
            float ar = 2.5f;
            string kimenet = string.Format("Ha nekem {0, 5} darab {1}em lenne {2:F} forintért, az lenne a {3} ", db, mi, ar, milyen);
            Console.WriteLine(kimenet);

            //Másolás - Substring
            string masolas = "Paróka";
            Console.WriteLine(masolas.Substring(2));
            Console.WriteLine(masolas); // az eredeti string nem változik meg

            //Szóközök eltávolítása egy stringből
            Console.Write("Kérlek, adj meg egy stringet szóközökkel ellátva: ");
            string bemenet = Console.ReadLine();

            kimenet = bemenet;

            do
            {
                int szokozHelye = kimenet.IndexOf(" ");

                if (szokozHelye != -1)
                {
                    kimenet = kimenet.Substring(0, szokozHelye) + kimenet.Substring(szokozHelye + 1, kimenet.Length - szokozHelye - 1); // -1 kell hogy ne indexeljük túl a stringet
                }

            } while (kimenet.Contains(" "));

            Console.WriteLine("Az eredmény: {0}", kimenet);
        }
    }
}