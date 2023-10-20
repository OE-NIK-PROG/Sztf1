using System;
using System.IO;
using System.Reflection.Metadata;

namespace Ismetlo_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Feladat:
            /*
             * Számolja meg egy felhasználótól bekért szövegben a maganhangzókat.
             */

            char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            Console.Write("Add meg a szót, amiben meg szeretnéd számolni a magánhangzókat: ");
            string szo = Console.ReadLine();
            int maganhangzo_db = 0;
            for (int i = 0; i < szo.Length; i++)
            {
                if (MaganhangzoVanEBenne(szo[i], maganhangzok))
                {
                    maganhangzo_db++;
                }
            }
            Console.WriteLine("A magánhangzók száma: " + maganhangzo_db);

            // 2.Feladat:
            /* 
             * Hozz létre egy paraméter nélküli static bool[,] Tombfeltoltes() metódust, amely létrehoz egy logikai értékeket tároló 10x10 - es mátrixot az alábbiak szerint. A létrejött mátrix lesz a metódus visszatérési értéke.
             * A mátrix elemei 70%-ban true, 30%-ban false értéket vesznek fel.
             * 2. Írasd ki a mátrixot 10x10-es alakban, melyhez készíts egy static void Tombkiiras(bool[,] tomb) visszatérési érték nélküli metódust. Paraméterként kapja meg a meghíváskor a mátrixot.
             * 3. Hozz létre egy static string TombkiirasString(bool[,] tomb) metódust, mely a bementként átadott tömb értékeit fűzi a kimeneti karakterlánchoz, a következő szabályos szerint:
             * - Az igaz értékek helyén egy „i” betű áll
             * - A hamis értékek helyén egy 10 és 100 közötti véletlen szám
             * - Az egyes elemek szóközzel, az sorok sortöréssel vannak elválasztva
            */

            // lentebb

            // 3.Feladat:
            /*
             * Javitott beillesztéses rendezés.
             * Kérjen be a felhasználótól egy elemszámot, hogy mennyi adatot szeretne a tömbben tárolni,
             * majd kérje be az adatokat amivel feltölti a tömböt. A bekért adatokat rendezze a fentebb
             * említett algoritmus segítségével.
             */

            // lentebb
        }

        // 1. FELADAT - mellék
        static bool MaganhangzoVanEBenne(char maganhangzo, char[] maganhangzok)
        {
            int i = 0;
            while (i < maganhangzok.Length && maganhangzok[i] != maganhangzo)
            {
                i++;
            }
            if (i < maganhangzok.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 2.FELADAT - mellék
        static bool[,] Tombfeltoltes()
        {
            bool[,] tomb = new bool[10, 10];
            Random r = new Random();

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    if (r.Next(1, 11) < 8) // igaz
                    {
                        tomb[i, j] = true;
                    }
                    else
                    {
                        tomb[i, j] = false;
                    }

                }
            }

            return tomb;
        }
        static void Tombkiiras(bool[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb[i, j]);
                }
                Console.WriteLine();
            }
        }

        static string TombkiirasString(bool[,] tomb)
        {
            string kimenet = "";
            Random r = new Random();

            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    if (tomb[i, j] == true)
                    {
                        kimenet += "i ";
                    }
                    else
                    {
                        kimenet += r.Next(10, 101) + " ";
                    }
                }
                kimenet += "\n";
            }

            return kimenet;
        }

        // 3.FELADAT - mellék
        static string[] TombBeker()
        {
            Console.Write("Tömb elemszáma: ");
            int elemszam = int.Parse(Console.ReadLine());
            string[] tomb = new string[elemszam];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Aktuális szöveg: ");
                tomb[i] = Console.ReadLine();
            }
            return tomb;
        }
        
        static bool StringKisebbE(string elso, string masodik)
        {
            int i = 0;
            while (i < elso.Length && i < masodik.Length && elso[i] == masodik[i])
                i++;
            if (i >= elso.Length)
                return true;
            if (i >= masodik.Length)
                return false;
            if (elso[i] < masodik[i])
                return true;
            return false;
        }

        static void JavitottBeillesztesesRendezes(string[] tomb)
        {
            for (int i = 1; i < tomb.Length; i++)
            {
                int j = i - 1;

                string seged = tomb[i];
                while (j >= 0 && StringKisebbE(seged, tomb[j]))
                {
                    tomb[j + 1] = tomb[j];
                    j = j - 1;
                }
                tomb[j + 1] = seged;
            }
        }



        static string StringTombMegjelenit(string[] tomb)
        {
            string s = "";
            foreach (string aktualis in tomb)
                s += aktualis + "\n";
            return s;
        }

        static void Csere(ref int egyik, ref int masik)
        {
            int seged = egyik;
            egyik = masik;
            masik = seged;
        }   
    }
}
