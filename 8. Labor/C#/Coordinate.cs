using System;

namespace OOP
{
    public class Koordinate
    {
        int x;
        int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Koordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
