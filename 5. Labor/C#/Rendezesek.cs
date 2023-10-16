using System;
using System.IO;
using System.Reflection.Metadata;

namespace Ismetlo_ora
{
    class Program
    {
        static Random r = new Random();
        private static int CompareTo(string a, string b)
        {
            // 0    egyenlőek
            // 0> x a megelőzi b-t
            // x< 0 b megelőzi a-t
            return string.Compare(a, b);
        }

        private static void Csere(ref string ls, ref string rs)
        {
            string seged = rs;
            rs = ls;
            ls = seged;
        }

        public static void BuborekRendezesSort(string[] szoveg)
        {
            for (int i = 0; i < szoveg.Length; i++)
            {
                for (int j = i + 1; j < szoveg.Length - 1; j++)
                {
                    if (CompareTo(szoveg[i], szoveg[j]) > 0)
                        Csere(ref szoveg[i], ref szoveg[j]);
                }
            }
        }


        static void Display(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        // ----------------------------------------

        static int[] Init()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(1, 21);
            }

            return numbers;
        }

        static void Display(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                    Console.Write(numbers[i]);
                else
                {
                    Console.Write(", " + numbers[i]);
                }
            }
        }

        static void MinimumKivalasztasosRendezes(int[] tomb)
        {
            // + Ha megkeressük a rendezés előtt a min elemet és az első helyre tesszük akkor a
            // cserék számát redukáljuk -> gyorsabb programfutás
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[min] > tomb[j])
                    {
                        min = j;
                    }
                }

                Csere(ref tomb[i], ref tomb[min]);
            }
        }

        //lf -> left side, rf-> right side.
        //private method / segéd metódus esetén nem kell tudnia a felhasználónak erről.
        private static void Csere(ref int lf, ref int rf)
        {
            int seged = lf;
            lf = rf;
            rf = seged;
        }


        static void Main(string[] args)
        {
            // BUBI Rendezés

            string[] szoveg = new string[] { "alma", "elefánt", "egér", "körte", "ajtó", "mobil" };
            Console.WriteLine("Rendezés előtt:");
            Display(szoveg);
            Console.WriteLine();
            BuborekRendezesSort(szoveg);
            Console.WriteLine("ReRendezés után:");
            Display(szoveg);


            // MIN Rendezés

            int[] numbers = Init();
            Display(numbers);
            MinimumKivalasztasosRendezes(numbers);
            Console.WriteLine();
            Display(numbers);

        }
    }
}
