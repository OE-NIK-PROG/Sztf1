using System;

namespace maffia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Az olasz maffia összesen 10 városban tevékenykedik, 
             * és az áldozataikat a lábukat betonba öntve beledobják egy közeli 100x100 méter méretű tóba 
             * (mindegyik város mellett van egy ugyanilyen tó). A rendőrség egyszer végignézi ezt a 10 tavat, 
             * és egy 10x100x100 méretű 3D tömbben tárolják el, hogy az egyes tavak adott koordinátáin hány hullát találtak.
             */

            // Készítsük el ezt a tömböt (0 és 9 közötti) random értékekkel feltöltve.

            int[,,] bodies = new int[10, 100, 100];
            Random rnd = new Random();

            for (int i = 0; i < bodies.GetLength(0); i++)
            {
                for (int j = 0; j < bodies.GetLength(1); j++)
                {
                    for (int k = 0; k < bodies.GetLength(2); k++)
                    {
                        bodies[i, j, k] = rnd.Next(0, 10);
                    }
                }
            }

            // Készítsük el olyan metódusokat, amely képes egy ill. az összes tó adatait kiírni.

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //DisplayLake(bodies, 0); // egy to kiirasa
            //Console.WriteLine(  );
            //DisplayAllLake(bodies);

            Console.WriteLine( );

            // Készítsünk egy olyan metódust, amely megmondja, hogy melyik város
            // maffia hálózata szedte a legtöbb áldozatot (és az áldozatok számát is írjuk mellé).

            MaxBodies(bodies);

            Console.WriteLine(  );

            // Készítsünk egy olyan metódust, amely egy tetszőleges tóban,
            // a parttól adott távolságban (sor index) lévő hullák számáról egy oszlopdiagramot rajzol.

            //DrawBodzGraph(bodies, 0, 2);

            Console.WriteLine(  );


            // Készítsünk olyan metódust, amely egy új 2D tömböt hoz létre,
            // ahol egy tetszőleges tó minden koordinátájára az adott tó átlag hullaszámtól való eltérése kerül.

            DistanceFromAverage(bodies, 0);

            // Készítsünk egy olyan metódust, amellyel nyomon követhetjük, ha a rendőrség új hullákat talál egy ponton,
            // kivesz egy vagy több hullát egy pontról, vagy kiemeli az összes hullát egy pontról (egy metódusban).

            Modify(bodies, 1, 0, 5, 15);

            Console.WriteLine( );

            // Készítsünk egy olyan metódust,
            // amely egy adott tó adott területén
            // (a bal felső és jobb alsó koordináták megadásával)
            // összeszámolja a hullákat.

            /*
             * TODO list
             * ---------
             * kell egy meth.                       X
             * to szama                             X
             * 4 koordinata (bal felso, jobb also)  X
             * testszamlalo                         X
             * ---------
             * osszegzes
             */

            CountOnArea(bodies, 1, 1, 1, 4, 4);

            // Készítsünk egy olyan metódust, amely egy új 2x[tavak száma] méretű tömbbe kiszedi az első sorba a tavak sorszámát,
            // a másodikba pedig az adott tóban lévő hullák számát, majd a hullák száma szerint csökkenő sorrendbe rendezi a tömböt.

            OrderByBodiesDesc(bodies);

            // FIN
            Console.ReadLine();
        }

        private static void OrderByBodiesDesc(int[,,] bodies)
        {
            // 2x[tavak száma]
            int[,] data = new int[2, bodies.GetLength(0)];
            for (int i = 0; i < bodies.GetLength(0); i++)
            {
                // első sorba a tavak sorszámát
                data[0, i] = i;
                int bodySum = 0;

                for (int j = 0; j < bodies.GetLength(1); j++)
                {
                    for (int k = 0; k < bodies.GetLength(2); k++)
                    {
                        bodySum += bodies[i, j, k];
                    }
                }
                // a másodikba pedig az adott tóban lévő hullák számát
                data[1, i] = bodySum;
            }

            for (int i = 0; i < data.GetLength(1) - 1 ; i++) // i = 1 ; i < data.GetLength(1)
            {
                for (int j = i + 1; j < data.GetLength(1); j++)
                {
                    if (data[1, i] < data[1, j])
                    {
                        int temp0 = data[0, i];
                        int temp1 = data[1, i];
                        // ---------------------
                        data[0, i] = data[0, j];
                        data[1, i] = data[1, j];
                        // ---------------------
                        data[0, j] = temp0;
                        data[1, j] = temp1;
                    }  
                }
            }
            Display2D(data, "\t");
        }

        private static void CountOnArea(int[,,] bodies, int lake, 
            int top, int left, int bottom, int right)
        {
            int bodySum = 0;

            for (int i = top; i < bottom; i++)
            {
                for (int j = left; j < right; j++)
                {
                    bodySum += bodies[lake, i, j];
                }
            }
            Console.WriteLine($"In lake {lake}, between the coords [{top},{left}] " +
                $"and [{bottom}, {right}], thee are {bodySum} bodies");
        }

        private static void Modify(int[,,] bodies, int lake, int row, int col, int val)
        {
            if (val == 0)
            {
                bodies[lake, row, col] = 0;
                Console.WriteLine($"The [{row}, {col}] position was reduced to 0");
            }
            else
            {
                bodies[lake, row, col] += val;
                Console.WriteLine($"IN lake {lake} the [{row}, {col}] " +
                    $"position was updated by {val}, it is now [{bodies[lake, row, col]}]");
            }
        }

        private static void DistanceFromAverage(int[,,] bodies, int lake)
        {
            int bodySum = 0;

            for (int i = 0; i < bodies.GetLength(1); i++)
            {
                for (int j = 0; j < bodies.GetLength(2); j++)
                {
                    bodySum += bodies[lake, i, j];
                }
            }

            int bodyAVG = bodySum / (bodies.GetLength(1) * bodies.GetLength(2));

            int[,] res = new int[bodies.GetLength(1), bodies.GetLength(2)];

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = bodies[lake, i, j] - bodyAVG;
                }
            }

            Display2D(res, " ");
        }

        private static void Display2D(int[,] res, string v)
        {
            for (int i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    Console.Write(res[i, j] + v);
                Console.WriteLine(  );
        }

        private static void DrawBodzGraph(int[,,] bodies, int lake, int dist)
        {
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 0; j < bodies.GetLength(2); j++)
                {
                    if (bodies[lake, dist, j] >= 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(  );
            }
        }

        private static void MaxBodies(int[,,] bodies)
        {
            int maxLake = 0;
            int maxBodies = 0;

            for (int i = 0; i < bodies.GetLength(0); i++)
            {
                int thisBodies = 0;
                for (int j = 0; j < bodies.GetLength(1); j++)
                {
                    for (int k = 0; k < bodies.GetLength(2); k++)
                    {
                        thisBodies += bodies[i, j, k];
                    }
                }
                if (thisBodies > maxBodies)
                {
                    maxBodies = thisBodies;
                    maxLake = i;
                }
            }

            Console.WriteLine($"Lake {maxLake} has the most bodies in it, whic is {maxBodies}");
        }

        private static void DisplayAllLake(int[,,] bodies)
        {
            for (int i = 0; i < bodies.GetLength(0); i++)
            {
                DisplayLake(bodies, i);
                Console.WriteLine( );
            }
        }

        private static void DisplayLake(int[,,] bodies, int x)
        {
            for (int i = 0; i < bodies.GetLength(1); i++)
            {
                for (int j = 0; j < bodies.GetLength(2); j++)
                {
                    Console.Write(bodies[x, i, j] + " ");
                }
                Console.WriteLine(  );
            }
        }
    }
}
