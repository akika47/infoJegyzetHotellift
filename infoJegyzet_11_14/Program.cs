using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Globalization;
using System.Diagnostics;
using System.Threading.Tasks;
using infoJegyzet_11_14;

namespace infoJegyzet_11_14
{
    class Program

    {
        static void Main(string[] args)
        {

            List<Lift> LiftAdatok = new List<Lift>();

            using (StreamReader sr = new StreamReader("lift.txt"))
            { 

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] split1 = sor.Split(' ');
                    Lift h = new Lift(Convert.ToDateTime(split1[0]), Convert.ToInt32(split1[1]), Convert.ToInt32(split1[2]), Convert.ToInt32(split1[3]));
                    LiftAdatok.Add(h);
                }
                sr.Close();
            }
            // int sorsz;

            int össz = 0;
            int mentek;
            for (int i = 0; i < LiftAdatok.Count; i++)

            {
                mentek = (LiftAdatok[i].InduloSzint + LiftAdatok[i].CelSzint);
                if (mentek > 0) {
                    össz++;
                }

            }
            Console.WriteLine($"3.feladat: Összes lifthasználat: {össz}");

            DateTime vegzes = LiftAdatok[össz - 1].Ido;
            DateTime kezdes = LiftAdatok[0].Ido;

            Console.WriteLine($"4.feladat: Időszak: {kezdes} - {vegzes}");

            Console.WriteLine($"Célszint max: {LiftAdatok.Max(x => x.CelSzint)}");

            Console.WriteLine("Kártya száma: ");
            int kartyaSzam;
 
            if (int.TryParse(Console.ReadLine(), out kartyaSzam) == false)
            {
                kartyaSzam = 5;
            }
   
            Console.WriteLine("Célszint száma: ");
            int celszintSzam;
            if (int.TryParse(Console.ReadLine(), out celszintSzam) == false)
            {
                celszintSzam = 5;
            }

        }
    }
}