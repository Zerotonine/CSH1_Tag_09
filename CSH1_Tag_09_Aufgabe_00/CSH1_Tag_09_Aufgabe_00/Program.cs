using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Song track1 = new Song();

            track1.Interpret = "Eminem";
            track1.Titel = "Farewell";
            track1.DauerSekunden = 247;

            track1.Spielen();
            Console.ReadKey();
        }
    }
}
