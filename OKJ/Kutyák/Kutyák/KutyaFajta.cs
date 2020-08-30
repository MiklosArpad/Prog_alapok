using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    public class KutyaFajta
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string eredetiNev { get; set; }

        public override string ToString()
        {
            return $"{id} {nev} {eredetiNev}";
        }
    }
}
