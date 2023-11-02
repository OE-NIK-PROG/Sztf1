using System;

namespace OOP
{
    public class Player
    {
        private int hp;
        private Weapon[] weapons;
        private string[] perks;
        private Skins skin;
        private Koordinate koordinate;
        public double speed;

        public int HP                   { get { return hp; } set { this.hp = value; } }
        public Weapon[] Weapons         { get { return weapons; } set { this.weapons = value; } }
        public string[] Perks           { get { return perks; } set { this.perks = value; } }
        public Skins Skin               { get { return skin; } set { this.skin = value; } }
        public Koordinate Koordinate    { get { return koordinate; } set { this.koordinate = value; } }
        public double Speed             { get { return speed; } set { this.speed = value; } }

        public Player() { }
        public Player(int hp, Weapon[] weapons, Koordinate koordinate)
        {
            this.hp = hp;
            this.weapons = weapons;
            this.koordinate = koordinate;
        }

        public Player(int hp, Weapon[] weapons, 
            string[] perks, Skins skins, Koordinate koordinate, double speed)
        {
            this.hp = hp;
            this.weapons = weapons;
            this.perks = perks;
            this.skin = skins;
            this.koordinate = koordinate;
            this.speed = speed;
        }

        // METHODS

        public void Move() { }
        public void Shoot() { }
        public void Reload() { }
        public void Damage(Player enemy)
        {
            this.HP -= enemy.weapons[0].Damage;

            Respawn();
        }
        private bool Die() 
        {
            if (this.HP <= 0)
            {
                return true;
            }
            return false; 
        }
        private void Respawn() 
        {
            if (Die())
            {
                // field
                this.koordinate.X = 0;

                // property
                this.Koordinate.Y = 0;
            }
        }
    }
}
