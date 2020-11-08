using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_05
{
    class Konto
    {
        public int Kontonummer;
        public string InhaberMail;
        public BankMitarbeiter Ansprechpartner;
        string geheimCode;
        double kontostand, dispo;

        public string GeheimCode 
        { 
            set
            {
                if(geheimCode == null)
                {
                    geheimCode = value;
                    Console.WriteLine($"E-Mail: Geheimcode auf {geheimCode} gesetzt!");
                }
                else
                {
                    Console.WriteLine("E-Mail: Geheimcode kann nur einmal angelegt werden, bei Problemen bitte Support kontaktieren!");
                }
            }
        }

        public bool SetDispo(int code, double dispo)
        {
            if(code == Ansprechpartner.GetCode(code))
            {
                this.dispo = dispo;
                return true;
            }
            return false;
        }

        public string GetKontostand()
        {
            if (kontostand < 0)
                return "keine Angabe";
            else if (kontostand > 100000)
                return "wohlhabend";

            return "Standard";
        }

        public bool Einzahlen(double betrag)
        {
            if(betrag > 0)
            {
                kontostand += betrag;
                return true;
            }
            return false;
        }

        public bool Abbuchen(double betrag, string code)
        {
            if(code == geheimCode && betrag <= kontostand+dispo)
            {
                kontostand -= betrag;
                return true;
            }
            return false;
        }
    }
}
