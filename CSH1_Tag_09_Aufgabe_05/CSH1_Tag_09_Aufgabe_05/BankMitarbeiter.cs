using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_05
{
    class BankMitarbeiter
    {
        static int id = 0;
        public int Id { get => id; }
        public string Name;
        private int bearbeitungsCode;

        public BankMitarbeiter()
        {
            id++;
        }

        public void SetCode(Random r)
        {
            if(bearbeitungsCode == 0)
            {
                bearbeitungsCode = r.Next(10000, 20001);
                Console.WriteLine($"Dies ist eine E-Mail, Ihr Bearbeitungscode lautet {bearbeitungsCode}");
            }
            else
            {
                Console.WriteLine("Code bereits gesetzt, bei Problemen bitte Support-Ticket eröffnen!");
            }
        }

        public int GetCode(int code)
        {
            return code == bearbeitungsCode ? bearbeitungsCode : 0;
        }
    }
}
