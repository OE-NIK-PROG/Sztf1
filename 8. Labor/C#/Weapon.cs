using System;

namespace OOP
{
    public class Weapon
    {
        // Adatmező
        private int ammo;
        private Skins skin;

        // lathatosag tipusa neve
        // prop + tab + tab
        public int Ammo { get { return ammo; } private set { ammo = value; } }
        public Skins Skin { get { return skin; } private set { skin = value; } }
        public int Damage { get; set; }

        // CONSTRUCTOR 
        // ctor + tab + tab
        public Weapon() { }

        public Weapon(int ammo = 30, Skins skin = Skins.DEFAULT)
        {
            this.ammo = ammo;
            this.skin = skin;
        }


    }
}
