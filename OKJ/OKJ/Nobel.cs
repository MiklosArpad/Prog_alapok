using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKJ
{
    public class Nobel
    {
        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string Keresztnev { get; set; }
        public string Vezeteknev { get; set; }

        public override string ToString()
        {
            return Ev + " " + Tipus + " " + Keresztnev + " " + Vezeteknev;
        }
    }
}
