using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Roboter r1 = new Roboter();

            r1.BatterieLaufzeit = 5;
            r1.Aufgabe = "Ich reiche Whisky!";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Durchlauf Nr. {i+1}");
                r1.FuehreAufgabeAus();
                Console.WriteLine("--------------------------------\n\n");
            }

            Console.ReadKey();
        }
    }
}
