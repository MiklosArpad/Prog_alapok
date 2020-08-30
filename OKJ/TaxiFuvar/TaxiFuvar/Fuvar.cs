using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiFuvar
{
    public class Fuvar
    {
        public int taxiId { get; set; }
        public string indulas { get; set; }
        public int idotartam { get; set; }
        public double tavolsag { get; set; }
        public double viteldij { get; set; }
        public double borravalo { get; set; }
        public string fizetesModja { get; set; }

        public override string ToString()
        {
            return $"{taxiId};{indulas};{idotartam};{tavolsag};{viteldij};{borravalo};{fizetesModja}";
        }
    }
}
