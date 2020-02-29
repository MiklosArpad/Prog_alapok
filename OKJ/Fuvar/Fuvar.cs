using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    public class Fuvar
    {
        public int TaxiId { get; set; }
        public string Indulas { get; set; }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double Viteldij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesModja { get; set; }

        public override string ToString()
        {
            return $"{TaxiId} {Indulas} {Idotartam} {Tavolsag} {Viteldij} {Borravalo} {FizetesModja}";
        }
    }
}
