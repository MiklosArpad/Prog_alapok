using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemia
{
    public class Felfedezes
    {
        public string Ev { get; set; }

        public string Elem { get; set; }

        public string Vegyjel { get; set; }

        public int Rendszam { get; set; }

        public string Felfedezo { get; set; }

        public override string ToString()
        {
            return Ev + " " + Elem + " " + Vegyjel + " " + Rendszam + " " + Felfedezo;
        }
    }
}
