using minta_ZH;
using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Import(Elado[] eladok)
        {
            int idx = 0;

            StreamReader sr = new StreamReader("eladok.txt");

            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                Elado elado = new Elado(
                    sor[0],
                    int.Parse(sor[1]),
                    (Stilus)Enum.Parse(typeof(Stilus), sor[2]));

                eladok[idx++] = elado;
            }

            sr.Close();

        }
        static void Main(string[] args)
        {
            Elado[] eladok = new Elado[EladokDB()];

            Import(eladok);

            for (int i = 0; i < eladok.Length; i++)
            {
                Console.WriteLine(eladok[i]);
            }

            Console.ReadLine();
        }

        private static int EladokDB()
        {
            int db = 0;

            StreamReader sr = new StreamReader("eladok.txt");

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                db++;
            }

            sr.Close();

            return db;
        }
    }
}
