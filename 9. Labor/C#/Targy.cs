using System;

namespace Neptun.classes
{
    public class Targy
    {
		private DateTime idopont;
        private int jegy;
        private bool vizsgasE;
        private int kreditErtek;
        private string nev;

        public DateTime Idopont
        {
			get { return idopont; }
			set { idopont = value; }
		}
	

		public int Jegy
		{
			get { return jegy; }
			set { jegy = value; }
		}

		public int KreditErtek
        {
			get { return kreditErtek; }
			set { kreditErtek = value; }
		}

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}


		public bool VizsgasE
		{
			get { return vizsgasE; }
			set { vizsgasE = value; }
		}

        public Targy() { }

        public Targy(DateTime idopont, int jegy, bool vizsgasE, int kreditErtek, string nev)
        {
            this.idopont = idopont; 
			this.jegy = jegy;
			this.vizsgasE = vizsgasE; ;
			this.kreditErtek =	kreditErtek;
			this.nev = nev;
        }
    }
}
