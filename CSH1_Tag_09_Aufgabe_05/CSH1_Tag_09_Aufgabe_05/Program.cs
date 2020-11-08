using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BankMitarbeiter bM = new BankMitarbeiter();
            Konto k1 = new Konto();

            bM.Name = "Rainer Jännicke";

            Console.WriteLine("Test Generierung B-Mitarbeiter SetCode");
            bM.SetCode(rnd);
            bM.SetCode(rnd);

            Console.WriteLine("Test Generierung B-Mitarbeiter GetCode");
            int code;
            do
            {
                Console.WriteLine("Bitte Bearbeitungscode eingeben");
            } while (!Int32.TryParse(Console.ReadLine(), out code));
                
            if(bM.GetCode(code) == code)
            {
                Console.WriteLine("Jo Code hat geklappt!");
            }
            else
            {
                Console.WriteLine("Code war falsch!");
            }
            
            Console.WriteLine("Ausgabe Felder B-Mitarbeiter");
            Console.WriteLine($"ID: {bM.Id}");
            Console.WriteLine($"Name: {bM.Name}");

            k1.Kontonummer = 1234;
            k1.InhaberMail = "edohle@wbs.sucks";
            k1.Ansprechpartner = bM;

            Console.WriteLine("Test set code bei Konto");
            k1.GeheimCode = "passwort";
            k1.GeheimCode = "1234";

            Console.WriteLine("Test SetDispo (Dispo wird auf 100 gesetzt)");
            Console.WriteLine("Bitte Bearbeitercode eingeben:");
            Int32.TryParse(Console.ReadLine(), out int bcode);
            
            if(k1.SetDispo(bcode, 100))
            {
                Console.WriteLine("Dispo auf 100 gesetzt!");
            }
            else
            {
                Console.WriteLine("Code falsch");
                   
            }
            
            Console.WriteLine("GetKontostand (0)");
            Console.WriteLine(k1.GetKontostand());

            Console.WriteLine("Test abbuchen (stand: 0; dispo: 100)");
            string eingabe;
            do
            {
                Console.WriteLine("Bitte Betrag eingeben: ");
                if(!Double.TryParse(Console.ReadLine(), out double betrag))
                    continue;
                Console.WriteLine("Bitte Pin eingeben:");
                eingabe = Console.ReadLine();
                
                if(k1.Abbuchen(betrag, eingabe))
                {
                    Console.WriteLine("Betrag abgebucht! - Für erneute Abbuchung F1 drücken");
                }
                else
                {
                    Console.WriteLine("Pin inkorrekt! Oder Betra zu hoch!- Für erneuten Versuch F1 drücken!");
                }

            } while (Console.ReadKey().Key == ConsoleKey.F1);

            Console.WriteLine("Test einzahlen");
            Console.WriteLine("Einzahlen 1.000.000");
            if(k1.Einzahlen(1000000))
                Console.WriteLine("Einzahlen OK!");
            else
                Console.WriteLine("Betrag muss positiv sein!");
            Console.WriteLine("Einzahlen -1.000.000");
            if(k1.Einzahlen(-1000000))
                Console.WriteLine("Einzahlen OK!");
            else
                Console.WriteLine("Betrag muss positiv sein!");
            Console.WriteLine("GetKontostand (~1.000.000)");
            Console.WriteLine(k1.GetKontostand());

            Console.ReadKey();
        }
    }
}
