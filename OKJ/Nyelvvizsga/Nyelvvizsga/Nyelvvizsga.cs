using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    public class Nyelvvizsga
    {
        public string Nyelv { get; set; }
        public int Darab2009 { get; set; }
        public int Darab2010 { get; set; }
        public int Darab2011 { get; set; }
        public int Darab2012 { get; set; }
        public int Darab2013 { get; set; }
        public int Darab2014 { get; set; }
        public int Darab2015 { get; set; }
        public int Darab2016 { get; set; }
        public int Darab2017 { get; set; }

        public int GetNyelvDarabszamaiOsszesEvben
        {
            get
            {
                return Darab2009 + Darab2010 + Darab2011 + Darab2012 + Darab2013 + Darab2014 + Darab2015 + Darab2016 + Darab2017;
            }
        }

        public override string ToString()
        {
            return $"{Nyelv} {Darab2009} {Darab2010} {Darab2011} {Darab2012} {Darab2013} {Darab2014} {Darab2015} {Darab2016} {Darab2017}";
        }
    }
}