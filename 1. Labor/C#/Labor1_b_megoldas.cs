using System;

namespace Labor1_b_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. FELADAT

            // Közös feladat - Zuhanó tusfürdős flakon
            // Számoljuk ki, hogy egy valamennyi másodpercig zuhanó tusfürdős flakon hány km/h sebességgel ért földet a zuhanyzóban. Az másodpercek értékét kérjük be a konzolról.
            Console.WriteLine("Hány másodpercig zuhant?");
            string resp = Console.ReadLine();
            double time = double.Parse(resp);
            double G = 10.0;
            double velocity_mps = G * time;
            double velocity_kmph = velocity_mps * 3.6;
            Console.WriteLine("A tusfürdő {0} km/h sebességgel ért földet.", velocity_kmph);

            Console.WriteLine("\n");

            #endregion

            #region 2. FELADAT

            // Önálló feladat - Százlábú sebessége
            // Ha egy száz lábú százlábú 10 mm/s sebességgel közlekedik és a sebessége a lábai számával
            // egyenesen arányos, milyen gyorsan halad egy olyan százlábú, amelynek valamennyi lába leszakadt? 
            // A leszakadt lábak számát kérjük be a konzolról.

            Console.WriteLine("Hány lába szakadt le?");
            int legs = 100 - int.Parse(Console.ReadLine());
            double full_speed = 10;
            double actual_speed = full_speed / 100 * legs;
            Console.WriteLine("Ez a {0}-lábú {1} mm/s sebességgel képes menni.", legs, actual_speed);

            #endregion

            #region 3. FELADAT

            // Önálló feladat - Vehet-e alkoholt?
            // Kérjük be egy illető nevét, ill. születési évét, majd névre szólóan írjuk ki, 
            // hogy kiadják-e neki az alkoholt a boltban. A születési hónappal, nappal ne törődjünk.

            Console.WriteLine("Hogy hívnak?");
            string name = Console.ReadLine();
            Console.WriteLine("Melyik évben születtél?");
            int year = int.Parse(Console.ReadLine());
            bool adult = 2020 - year >= 18;
            Console.WriteLine("{0} kaphat-e a boltban alkoholt: {1}", name, adult);

            Console.WriteLine("\n");

            #endregion

            #region 4. FELADAT

            // Önálló feladat - Pizza hasznos része
            // Kérjük be egy pizza átmérőjét és a pereme szélességét, majd számoljuk ki, és írjuk ki,
            // hogy a pizza felületének hány százalékán van feltét.

            Console.WriteLine("Hány cm a pizza átmérője?");
            double diam = double.Parse(Console.ReadLine());
            Console.WriteLine("Hány cm széles a pizza pereme?");
            double edge = double.Parse(Console.ReadLine());
            double total_area = Math.PI * Math.Pow(diam / 2, 2);
            double filled_area = Math.PI * Math.Pow((diam / 2) - edge, 2);
            double filling_rate = filled_area / total_area * 100;
            Console.WriteLine("A pizza {0} százalékán van feltét.", filling_rate);

            Console.WriteLine("\n");

            #endregion

            #region 5. FELADAT

            // Önálló feladat - Jegyzet besatírozás
            // Egy ceruzával 4 darab A4-es oldalt lehet besatírozni, mielőtt elfogyna. 
            // Kérjünk be egy színt a konzolról, és számoljuk ki, hány ceruza kell ahhoz, 
            // hogy teljesen besatírozzuk az Sztf1 jegyzetnek mind a 292 oldalát ezzel a színnel.

            Console.WriteLine("Milyen színű a ceruza?");
            string color = Console.ReadLine();
            int pencils = (int)Math.Ceiling(292.0 / 4.0);
            Console.WriteLine("Csak {0} db ceruza kellett hozzá, de az egész jegyzet szép {1} lett.", pencils, color);

            #endregion

            Console.ReadKey();
        }
    }
}
