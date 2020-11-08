using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_03
{
    class B_Spieler
    {
        public string Name;
        public int x, y;
        public bool ImSpiel;

        public B_Spieler()
        {
            ImSpiel = true;
        }
        public B_Spieler(string name)
        {
            Name = name;
            ImSpiel = true;
        }

        public void Jubeln()
        {
            Console.WriteLine("Wir B-Spieler sind Siegertypen!");
        }

        public void Heulen()
        {
            Console.WriteLine("Pah, der A-Spieler hatte nur Glück...");
        }

        public void Gruessen(B_Spieler bS)
        {
            Console.WriteLine($"Moin {bS.Name}");
        }
    }
}
