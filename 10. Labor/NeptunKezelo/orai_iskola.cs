using Neptun.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.classes
{
    internal class Iskola
    {
		private string nev;
        private string cim;
        private Hallgato[] hallgatok;
		private Szak[] szakok;

        public string Nev { get { return nev; }}
		public string Cim { get { return cim; } set { cim = value; } }

		public Hallgato[] Hallgatok
		{
			get { return hallgatok; }
			private set { hallgatok = value; }
		}

        public Szak[] Szakok { get; set; }

        public Iskola()
        {
            
        }

        public Iskola(string nev, string cim, Szak[] szakok)
        {
            this.nev = nev;
            this.cim = cim; 
            this.szakok = szakok;

            this.hallgatok = new Hallgato[10];
        }

        public void HallgatokLekerdezese()
        {
            foreach (Hallgato hallgato in hallgatok)
                Console.WriteLine(hallgato.ToString());
        }

        public void HallgatokFelvetele(Hallgato[] hallgatok)
        {
            this.hallgatok = hallgatok;
        }

        public void HallgatokFelvetele(Hallgato hallgato)
        {
            int idx = 0;

            while (idx < this.hallgatok.Length &&
                hallgatok[idx] != null)
                idx++;

            if (idx < this.hallgatok.Length)
                this.hallgatok[idx] = hallgato;
            else
                Console.WriteLine("[WARNING] - Nincs több hely az egyetemen!");
        }

        public void HallgatoKirugasa(Hallgato hallgato)
        {
            int idx = 0;

            while (idx < this.hallgatok.Length &&
                hallgatok[idx] != hallgato)
                idx++;

            if (idx < this.hallgatok.Length)
                this.hallgatok[idx] = null;
            else
                Console.WriteLine("[WARNING] - Nem található a hallgató");
        }

        public Hallgato HallgatoKeresese(string neptunkod)
        {
            Hallgato temp = HallgatoKereseseDB(neptunkod);
            if (temp != null)
                return temp;
            else
                return null;
        }

        private Hallgato HallgatoKereseseDB(string neptunkod)
        {
            int idx = 0;

            while (idx < this.hallgatok.Length &&
                hallgatok[idx].Neptunkod != neptunkod)
                idx++;

            if (idx < this.hallgatok.Length)
                return this.hallgatok[idx];
            else
                return null;
        }
    }
}
