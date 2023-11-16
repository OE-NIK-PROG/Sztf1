using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.classes
{
    internal class Targy
    {
		private string nev;
        private string dolgozatDatuma;
        private int kredit;
        private bool vizsgas;

        public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		public int Kredit
		{
			get { return kredit; }
			set { kredit = value; }
		}
		public bool Vizsgas
		{
			get { return vizsgas; }
			set { vizsgas = value; }
		}

		public string DolgozatDatuma
        {
			get { return dolgozatDatuma; }
			set { dolgozatDatuma = value; }
		}

        public Targy()
        {
            
        }
        public Targy(string nev, int kredit, bool vizsgas, string dolgozatDatuma)
        {
            this.nev = nev;
			this.kredit = kredit;
			this.vizsgas = vizsgas;
			this.dolgozatDatuma = dolgozatDatuma;
        }


    }
}
