using System;
using System.Collections.Generic;

namespace tisd4
{
    class Program
    {
        struct BaggageOfPassenger
        {
            public string nameofpassenger; // имя пассажир
            public int veschi; // количество вещей
            public double ves; // вес в кг 
            public BaggageOfPassenger(string nameofpassenger, int veschi, double ves)
            {
                this.nameofpassenger = nameofpassenger;
                this.veschi = veschi;
                this.ves = ves;
            }
        }
        static void Main(string[] args)
        {
            List<BaggageOfPassenger> bop = new List<BaggageOfPassenger>();
            bop.Add(new BaggageOfPassenger("Greg",       5,   4.231)); 
            bop.Add(new BaggageOfPassenger("Antuan",     7,   5.878));
            bop.Add(new BaggageOfPassenger("Alukard",    10,  3.120));
            bop.Add(new BaggageOfPassenger("Aiden",      13,  2.516));
            bop.Add(new BaggageOfPassenger("Persival",   5,   4.682));
            bop.Add(new BaggageOfPassenger("Artur",      7,   6.138));
            bop.Add(new BaggageOfPassenger("Peter",      12,  1.237));
            bop.Add(new BaggageOfPassenger("Rick",       24,  8.653));

            Console.WriteLine("Пассажиры:");
            foreach (BaggageOfPassenger b in bop)
                Console.WriteLine($"{b.nameofpassenger,-10} \t {b.veschi,-10} \t {b.ves,-10}");

            Console.WriteLine();


            int i;
            // поиск одинакового количества вещей среди пассажиров
            for (i = 0; i < bop.Count; i++)
            {
                for (int j = i + 1; j < bop.Count; j++)
                {
                    if (bop[i].veschi == bop[j].veschi & Math.Abs(bop[i].ves - bop[j].ves) <= 0.5)
                    {
                        Console.WriteLine($"Количество вещей пассажира " + bop[i].nameofpassenger +
                        " совпадает с количеством вещей пассажира " + bop[j].nameofpassenger +
                        " и не различается по весу в 0,5 кг");
                    }
                }
            }
            // поиск максимального количества вещей и веса среди пассажиров
            int max1 = bop[0].veschi;
            double max2 = bop[0].ves;
            for (i = 0; i < bop.Count; i++)
            {
                if (max1 < bop[i].veschi & max2 < bop[i].ves)
                {
                    max1 = bop[i].veschi;
                    max2 = bop[i].ves;
                }
                if (i == bop.Count-1)
                {
                    Console.WriteLine("\nПассажир " + bop[i].nameofpassenger + " имеет наибольшее количество вещей - " + bop[i].veschi + " и наибольший вес - " + bop[i].ves);

                }
            }
        }
    }
}
