using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   internal class Pilota
   {
        public string name { get; set; }
        public string szuletes { get; set; }
        public string nemzet { get; set; }
        public int rszam { get; set; }
        public int year { get; set; }

        public Pilota(string sor)
        {
            var adat = sor.Split(';');
            name = adat[0];
            szuletes = adat[1];
            nemzet = adat[2];
            rszam = (adat[3].Length > 0) ? int.Parse(adat[3]) : 0;
            year = int.Parse(adat[1].Substring(0, 4));
        }
    }
}
