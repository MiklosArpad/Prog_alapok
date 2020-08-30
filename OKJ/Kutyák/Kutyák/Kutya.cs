using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyák
{
    public class Kutya
    {
        public int id { get; set; }
        public int fajtaId { get; set; }

        public int nevId { get; set; }
        public int eletkor { get; set; }
        public string utolsoOrvosiEllenorzes { get; set; }

        public override string ToString()
        {
            return $"{id} {fajtaId} {nevId} {eletkor} {utolsoOrvosiEllenorzes}";
        }

    }
}
