using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSH1_Tag_09_Aufgabe_03
{
    class A_Spieler
    {
        public string Name;
        public int x, y;
        public bool ImSpiel;

        public A_Spieler() // ctor setzt ImSpiel auf true bei Erzeugung des Objektes
        {
            ImSpiel = true;
        }
        public A_Spieler(string name)
        {
            Name = name;
            ImSpiel = true;
        }

        public void Jubeln()
        {
            Console.WriteLine("Ich liebe es wenn ein Plan funktioniert!");
        }

        public void Heulen()
        {
            Console.WriteLine("Ich hasse es wenn ein Plan scheitert!");
        }

        public void Gruessen(A_Spieler aS)
        {
            Console.WriteLine($"Hallo {aS.Name}!");
        }
    }
}
