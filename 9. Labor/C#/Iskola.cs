using System;

namespace Neptun.classes
{
    public class Iskola
    {
		private string cim;
        private string nev;

        public string Cim { get { return cim; } private set { cim = value; } }
		public string Nev { get { return nev; } private set { nev = value; } }

        public Iskola() { }
        public Iskola(string nev, string cim)
		{
			this.nev = nev;
			this.cim = cim;
			// cim = this.cim; >> nem jo			
		}

        public override string ToString()
        {
            return $"{nev} - {cim}";
        }
    }
}
