using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Schachfeld feld = new Schachfeld();

            ConsoleKey ck = new ConsoleKey();
            while(ck != ConsoleKey.Escape)
            {
                Console.WriteLine(feld.Zufallsfeld());

                Thread.Sleep(300);
                if (Console.KeyAvailable)
                    ck = Console.ReadKey(true).Key;
            }
            Console.ReadKey();
        }
    }
}
