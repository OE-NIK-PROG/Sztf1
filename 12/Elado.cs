using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minta_ZH
{
    public class Elado
    {
        // CTOR + TAB + TAB

        //---------------------
        // ADATTAGOK
        private string nev;
        //---------------------

        //---------------------
        // TULAJDONSAG >> PROP + TAB + TAB
        public string Nev { get { return this.nev; } /*set { this.nev = value; }*/ }
        //---------------------

        // ............
        //      \/

        // PROPFULL + TAB + TAB

        private int kor;
        private Stilus stilus;
        private int kapottBorravalo;

        public int Kor { get { return kor; } }
        public Stilus Stilus { get { return stilus; } }
        public int KapottBorravalo{ get { return kapottBorravalo; } set { kapottBorravalo = value; } }

        //---------------------
        // KONSTRUKTOR
        public Elado() { }
        public Elado(string nev, int kor, Stilus stilus) 
        {
            this.nev = nev;
            this.kor = kor;
            this.stilus = stilus;

            this.kapottBorravalo = 0; // kezdeti ertek
        }
        //---------------------

        //---------------------
        // METODUSOK
        public int Elad(Vasarlo vasarlo, Sutik suti)
        {
            if (this.stilus == Stilus.Kedves /*&& kedvenc suti vizsgalat*/)
                this.kapottBorravalo = 200;

            switch (suti)
            {
                case Sutik.Keksz: return (int)Sutik.Keksz * 500 + this.kapottBorravalo;

                case Sutik.Fank: return (int)Sutik.Fank * 500 + this.kapottBorravalo;

                case Sutik.Muffin: return (int)Sutik.Muffin * 500 + this.kapottBorravalo;

                case Sutik.Almatorta: return (int)Sutik.Almatorta * 500 + this.kapottBorravalo;

                default: return 0;
            }
        }

        public string Valami()
        {
            return "";
        }
        //---------------------
    }
}
