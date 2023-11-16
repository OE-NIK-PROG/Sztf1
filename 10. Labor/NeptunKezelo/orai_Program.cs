using Neptun.classes;
using Neptun.enums;
using System.IO;

namespace Neptun
{
    internal class Program
    {
        static Hallgato[] HallgatokBeolvasasaDB()
        {
            Hallgato[] tempHallgatok = new Hallgato[HallgatokDB()];

            StreamReader sr = new StreamReader("hallgatokDB.txt");

            int i = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] temp = line.Split('|');

                //tempHallgatok[i] = new Hallgato(temp[0], temp[1], temp[2],
                //                                temp[3], TagozatKivalasztasa(temp[4]));

                

                tempHallgatok[i] = new Hallgato(temp[0], temp[1], temp[2],
                                                temp[3],
                                                (Tagozat)Enum.Parse(typeof(Tagozat), temp[4]));
                i++;
            }

            sr.Close();

            return tempHallgatok;
        }

        private static Tagozat TagozatKivalasztasa(string tagozat)
        {
            switch (tagozat) 
            {
                case "Nappali": return Tagozat.NAPPALI;
                case "": return Tagozat.ESTIS;
                default: return Tagozat.LEVELEZO;
            }
        }

        private static int HallgatokDB()
        {
            int db = 0;

            StreamReader sr = new StreamReader("hallgatokDB.txt");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                db++;
            }

            sr.Close();

            return db;
        }

        static void Main(string[] args)
        {

            Hallgato[] hallgatok = HallgatokBeolvasasaDB();

            

            Iskola iskola = new Iskola("OE", "Becsi ut", new Szak[] 
            {Szak.MERNOK_INFO, Szak.MERNOK_VARRONO});

            iskola.HallgatokFelvetele(hallgatok);

            Console.WriteLine(iskola.Nev + " :" );
            for (int i = 0; i < iskola.Hallgatok.Length; i++)
            {
                Console.WriteLine(iskola.Hallgatok[i]);
            }

            Console.ReadLine();
        }
    }
}
