using Neptun.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.classes
{
	public class Hallgato
    {
		private DateTime beiratkozasIdeje;
        private Iskola iskola;
        private string neptunKod;
        private Targy[] targyak;
        private string nev;
        private int passzivFelevekSzama;
        private DateTime szuletes;
        private Tagozatok tagozat;

        public DateTime BeiratkozasIdeje
		{
			get { return beiratkozasIdeje; }
            private set { beiratkozasIdeje = value; }
		}


		public Iskola Iskola
		{
			get { return iskola; }
            private set { iskola = value; }
		}

		

		public string NeptunKod
		{
			get { return neptunKod; }
            private set { neptunKod = value; }
		}

	
		public string Nev
		{
			get { return nev; }
            private set { nev = value; }
		}

		

		public int PasszivFelevekSzama
		{
			get { return passzivFelevekSzama; }
            private set { passzivFelevekSzama = value; }
		}

		

		public DateTime Szuletes
		{
			get { return szuletes; }
            private set { szuletes = value; }
		}

		

		public Tagozatok Tagozat
		{
			get { return tagozat; }
            private set { tagozat = value; }
		}

		

		public Targy[] Targyak
		{
			get { return targyak; }
			private set { targyak = value; }
		}

        public Hallgato()
        {
            
        }

        public Hallgato(DateTime beiratkozasIdeje, Iskola iskola, string neptunKod, string nev, int passzivFelevekSzama, DateTime szuletes, Tagozatok tagozat, Targy[] targyaks)
        {
            this.beiratkozasIdeje = beiratkozasIdeje;
			this.iskola = iskola;
			this.neptunKod = neptunKod;
			this.nev = nev;
			this.targyak = targyak;
			this.szuletes = szuletes;
			this.tagozat = tagozat;
			this.passzivFelevekSzama = passzivFelevekSzama;
        }


    }
}
