using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_feladatok
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * MINDEN ESETBEN KÜLÖN METÓDUSSAL VALÓSÍTSA MEG A FELADATOT!
             * 
             * Készítsen konzolos alkalmazást, amely...
             * 
             * 1. FELADAT
             * ...a felhasználótól bekér egy tetszőleges karaktersorozatot, majd azt kiírja a konzolra csupa nagybetűvel.
             * 
             * 
             * 2. FELADAT
             * ...a felhasználótól bekéri a teljes nevét, majd megvizsgálja, hogy az első-első betű nagybetű-e.
             * Ha igen, akkor ne végezzen módosítást.
             * Ha viszont kis betű, akkor tegye őket nagybetűvé és írassa ki az eredeti majd módosított állapotot.
             * 
             * 
             * 3. FELADAT
             * ... amely bekér egy karatersorozatot a felhasználótól.
             * A karatersorozat várható formája a következő: ___@___@___
             * Ahol az első __ hely a vezetéknevet, a második __ hely a keresztnevet, az utolsó __ pedig az évszámot reprezentálja.
             * Írja ki az eredeti és fordított sorrendben a karaktereket.
             * 
             * */

            // 1. FELADAT
            string bekertAdat = BekeresVegyes();
            NagybetusseAlakitas(bekertAdat);

            // 2. FELADAT
            string[] bekertnev = BekeresNev();
            NagybetusE(bekertnev[0], bekertnev[1]);

            // 3. FELADAT
            Megfordit(BekerNevEvszam()); // metódus metódusba ágyazva

        }
    }
}
