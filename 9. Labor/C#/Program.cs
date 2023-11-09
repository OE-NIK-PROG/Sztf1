using Neptun.classes;
using Neptun.enums;

namespace Neptun
{
    internal class Program
    {
        private static void TargyakFelvetele(Targy targy,ref Targy[] targyak)
        {
            int i = 0;

            // rovidzar kiertekeles
            while ((i < targyak.Length) && (targyak[i] != null))
                i++;

            if (i < targyak.Length)
                targyak[i] = targy;
        }

        private static Hallgato HallgatokLetrehozasa(Iskola iskola, 
            string neptunkod, string nev, int pszFelev, 
            DateTime szuletes, Tagozatok tagozat, Targy[] targyak)
        {

            return new Hallgato(DateTime.Now,
                iskola, neptunkod, nev, pszFelev, szuletes,
                tagozat, targyak);

        }

        static void Main(string[] args)
        {
            int targyakDB = 3;
            Targy[] targyak = new Targy[targyakDB];
            Hallgato[] hallgatok = new Hallgato[2];

            TargyakFelvetele(
                new Targy() 
                { 
                    Nev = "ANAL", 
                    Jegy = 5, 
                    VizsgasE = true, 
                    KreditErtek = 6, 
                    Idopont = DateTime.Now 
                }, ref targyak);
            TargyakFelvetele(
                new Targy()
                {
                    Nev = "PROG",
                    Jegy = 4,
                    VizsgasE = true,
                    KreditErtek = 5,
                    Idopont = DateTime.Now
                }, ref targyak);
            TargyakFelvetele(
                new Targy()
                {
                    Nev = "MIKRO",
                    Jegy = 2,
                    VizsgasE = true,
                    KreditErtek = 11,
                    Idopont = DateTime.Now
                }, ref targyak);

            Iskola iskola = new Iskola("OE", "BUDAPEST");


            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i] = HallgatokLetrehozasa(iskola,
                    i.ToString() + "ASD", i.ToString() + " Hallgato",
                    i, DateTime.Parse("1999/11/11"), 
                    Tagozatok.Nappali, targyak);
            }

            foreach (Hallgato item in hallgatok)
            {
                Console.WriteLine(item.Iskola);
            }

            Console.ReadLine();
        }
    }
}
