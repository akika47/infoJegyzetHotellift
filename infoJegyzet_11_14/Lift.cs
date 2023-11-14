using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infoJegyzet_11_14
{
    internal class Lift
    {
        DateTime ido;
        int sorszam;
        int induloSzint;
        int celSzint;

        public Lift(DateTime ido, int sorszam, int induloSzint, int celSzint)
        {
            this.ido = ido;
            this.sorszam = sorszam;
            this.induloSzint = induloSzint;
            this.celSzint = celSzint;
        }

        public DateTime Ido { get => ido; }
        public int Sorszam { get => sorszam; }
        public int InduloSzint { get => induloSzint; }
        public int CelSzint { get => celSzint; }
    }
}
