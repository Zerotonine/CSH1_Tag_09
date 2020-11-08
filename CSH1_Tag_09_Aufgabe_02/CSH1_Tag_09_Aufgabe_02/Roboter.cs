using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_02
{
    class Roboter
    {
        public int BatterieLaufzeit;
        public string Aufgabe;


        public bool IstBatterieLaufzeitNiedrig()
        {
            if (BatterieLaufzeit < 2)
                return true;

            return false;
        }

        public void FuehreAufgabeAus()
        {
            if(!IstBatterieLaufzeitNiedrig())
            {
                Console.WriteLine(Aufgabe);
                BatterieLaufzeit--;
            } else
            {
                Console.WriteLine("BaaBooBeep Ich muss aufgeladen werden :(");
            }
            
        }
    }
}
