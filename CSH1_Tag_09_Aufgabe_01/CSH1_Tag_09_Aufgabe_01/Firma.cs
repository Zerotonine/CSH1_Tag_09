using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_01
{
    class Firma
    {
        public string Name;
        public List<double> Konten = new List<double>();

        public double Summe()
        {
            return Konten.Sum();
        }
    }
}
