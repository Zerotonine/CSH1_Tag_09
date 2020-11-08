using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt();

            p1.Mindestpreis = 10;
            p1.Verkaufspreis = 5;

            Console.WriteLine("VK auf 5 gesetzt");
            Console.WriteLine($"VK lautet(mindestpreis): {p1.Verkaufspreis}");
            p1.Verkaufspreis = 100;
            Console.WriteLine("VK auf 100 gesetzt");
            Console.WriteLine($"VK lautet: {p1.Verkaufspreis}");
            Console.WriteLine($"Produktname: {p1.Name}");
            Console.WriteLine($"Produktcounter: {p1.Counter}");
            p1.Name = "Xbox Series X";
            Console.WriteLine($"Produktname: {p1.Name}");
            Console.WriteLine($"Produktcounter: {p1.Counter}");
            Console.WriteLine($"Produktname: {p1.Name}");
            Console.WriteLine($"Produktcounter: {p1.Counter}");

            Console.ReadLine();
        }
    }
}
