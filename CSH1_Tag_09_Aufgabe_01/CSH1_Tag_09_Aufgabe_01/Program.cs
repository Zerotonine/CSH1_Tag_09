using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f1 = new Firma();
            Firma f2 = new Firma();

            f1.Name = "Winzigweich";
            f1.Konten.Add(1000.23);
            f1.Konten.Add(2000.33);

            f2.Name = "Apfel";
            f2.Konten.Add(10);
            f2.Konten.Add(20);
            f2.Konten.Add(30.5054);

            List<Firma> firmen = new List<Firma>() { 
                f1,
                f2
            };

            foreach(Firma f in firmen)
            {
                Console.WriteLine($"Firma:\t\t{f.Name}");
                Console.WriteLine($"Gesamtbetrag:\t{f.Summe():0.00}EUR");
                Console.WriteLine("--------------------------------------------\n\n");
            }

            Console.ReadKey();
        }
    }
}
