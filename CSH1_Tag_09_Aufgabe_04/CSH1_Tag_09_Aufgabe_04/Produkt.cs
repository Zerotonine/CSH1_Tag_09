using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_04
{
    class Produkt
    {
        public int Counter;
        string name;
        int mindestpreis, verkaufspreis;
        public string Name 
        {
            get
            {
                if(name == null)
                {
                    return "undefinded";
                }
                Counter++;
                return name;
            }
            set => name = value;
        }

        public int Mindestpreis { set => mindestpreis = value; }
        public int Verkaufspreis 
        {
            get => verkaufspreis; 
            set
            {
                if (value > mindestpreis)
                    verkaufspreis = value;
                else
                    verkaufspreis = mindestpreis;
            }
        }

    }
}
