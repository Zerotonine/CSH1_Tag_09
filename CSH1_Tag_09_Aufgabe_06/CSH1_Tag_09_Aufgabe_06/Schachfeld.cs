using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_06
{
    class Schachfeld
    {
        Random rnd = new Random();
        string column = "abcdefgh";

        private string Column()
        {
            return column[rnd.Next(0, 8)].ToString();
        }

        private string Row()
        {
            return rnd.Next(1, 9).ToString();
        }

        public string Zufallsfeld()
        {
            return Column() + Row();
        }
    }
}
