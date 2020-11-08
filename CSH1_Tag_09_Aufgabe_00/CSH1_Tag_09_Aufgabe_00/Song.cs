using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_00
{
    class Song
    {
        public string Titel, Interpret;
        public int DauerSekunden;

        public void Spielen()
        {
            int min = DauerSekunden / 60;
            int sek = DauerSekunden % 60;
            Console.WriteLine($"Interpret:\t{Interpret}");
            Console.WriteLine($"Titel:\t\t{Titel}");
            Console.WriteLine($"Dauer:\t\t{min:D2}:{sek:D2}");
        }
    }
}
