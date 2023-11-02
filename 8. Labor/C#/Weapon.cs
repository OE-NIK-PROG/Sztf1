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
        public Weapon(): this(30, Skins.DEFAULT) { } // EMPTY CONSTRUCTOR with default value

        public Weapon(int ammo, Skins skin)
            
        {
            this.ammo = ammo;
            this.skin = skin;
        }
    }
}
