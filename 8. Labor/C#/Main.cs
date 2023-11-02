using System;

namespace OOP
{
    // class
    internal class Program
    {

        static void Main(string[] args)
        {
            //Weapon wp1 = new Weapon(); // példányosítás
            //Weapon wp2 = new Weapon();

            //Console.WriteLine(wp2.Ammo);

            Weapon machinegun = new Weapon(30, Skins.DEFAULT);
            Weapon knife = new Weapon(100, Skins.GOLD);

            machinegun.Damage = 45;
            knife.Damage = 80;

            // ===================
            // TOMB FELTOLTES 3 FELE KEPPEN

            Weapon[] weapons = new Weapon[2];

            weapons[0] = machinegun;
            weapons[1] = knife;

            // -------------------
            /*
            Weapon[] weapons_alt = new Weapon[] { machinegun, knife };
            */
            // -------------------
            /*
            Weapon[] weapons_alt_2 = new Weapon[] { 
                new Weapon(30, Skins.NAVY), 
                new Weapon() { Ammo = 20, Skin = Skins.NAVY },
            */
            // -------------------

            string[] perks = new string[3] { "FAST MOVE", "FAST RELOAD", "LAST MAN STANDING" };

            Player p1 = new Player(100, weapons, perks, Skins.GOLD, 
                new Koordinate(0, 0), 20);

            Player enemy = new Player(100, weapons, perks, Skins.GOLD,
               new Koordinate(0, 0), 20);


            Console.WriteLine("BEFORE DAMAGE");
            Console.WriteLine(p1.HP);

            p1.Damage(enemy);

            Console.WriteLine("AFTER DAMAGE");
            Console.WriteLine(p1.HP);

            Console.WriteLine("NEW WEAPON with default value:");
            Weapon w_default = new Weapon();
            Console.WriteLine($"Default skin: {w_default.Skin}");


            Console.ReadLine();
        }
    }
}
