using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    public class KutyaNev
    {
        public int id { get; set; }
        public string kutyanev { get; set; }

        public override string ToString()
        {
            return $"{id} {kutyanev}";
        }
    }
}
