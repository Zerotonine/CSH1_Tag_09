using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_09_Aufgabe_03
{
    enum Sieger
    {
        istA,
        istB
    }
    class Program
    {
        const short feldMax_X = 5;
        const short feldMax_Y = 10;
        static void Main(string[] args)
        {
            #region Spieler A anlegen
            A_Spieler achim = new A_Spieler("Achim");
            A_Spieler anja = new A_Spieler("Anja");
            A_Spieler anton = new A_Spieler("Anton");
            A_Spieler alma = new A_Spieler("Alma");
            A_Spieler axel = new A_Spieler("Axel");
            #endregion

            #region Spieler B anlegen
            B_Spieler belinda = new B_Spieler("Belinda");
            B_Spieler barbara = new B_Spieler("Barbara");
            B_Spieler bjoern = new B_Spieler("Björn");
            B_Spieler bianca = new B_Spieler("Bianca");
            B_Spieler bruno = new B_Spieler("Bruno");
            #endregion

            #region Listen
            List<A_Spieler> aListe = new List<A_Spieler>()
            {
                achim,
                anja,
                anton,
                alma,
                axel
            };

            List<B_Spieler> bListe = new List<B_Spieler>()
            {
                belinda,
                barbara,
                bjoern,
                bianca,
                bruno
            };
            #endregion

            #region Anfangsposition auslosen
            Random rnd = new Random();
            short x;
            short y;
            foreach(A_Spieler aS in aListe)
            {
                do
                {
                    x = (short)rnd.Next(0, feldMax_X );
                    y = (short)rnd.Next(0, feldMax_Y / 2);
                } while (aListe.FindAll(a=>a.x==x).Any(a=>a.y==y));

                aS.x = x;
                aS.y = y;
            }

            foreach (B_Spieler bS in bListe)
            {
                do
                {
                    x = (short)rnd.Next(0, feldMax_X);
                    y = (short)rnd.Next(feldMax_Y / 2, feldMax_Y);
                } while (bListe.FindAll(b => b.x == x).Any(b => b.y == y));

                bS.x = x;
                bS.y = y;
            }
            #endregion

            for(int i = 0; i < feldMax_Y; i++)
            {
                for (int j = 0; j < feldMax_X; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("o");
                }
            }

            foreach(A_Spieler aS in aListe)
            {
                Console.SetCursorPosition(aS.x, aS.y);
                Console.Write("A");
            }
            foreach (B_Spieler bS in bListe)
            {
                Console.SetCursorPosition(bS.x, bS.y);
                Console.Write("B");
            }

            Console.SetCursorPosition(0, feldMax_Y + 2);

            Console.WriteLine("Testausgabe Listen\n");
            Console.WriteLine("Spieler A");
            Console.WriteLine("----------------------------------");
            foreach(A_Spieler aS in aListe)
            {
                Console.WriteLine($"Name => {aS.Name}");
                Console.WriteLine($"X => {aS.x}");
                Console.WriteLine($"Y => {aS.y}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nSpieler B");
            Console.WriteLine("----------------------------------");
            foreach (B_Spieler bS in bListe)
            {
                Console.WriteLine($"Name => {bS.Name}");
                Console.WriteLine($"X => {bS.x}");
                Console.WriteLine($"Y => {bS.y}");
                Console.WriteLine("\n");
            }

            Console.ReadKey();
            Console.Clear();

            while(aListe.Any(a=>a.ImSpiel==true) && bListe.Any(b=>b.ImSpiel == true))
            {
                //! Schicke A-Spieler auf Nachbarfeld
                foreach(A_Spieler aS in aListe.FindAll(a=>a.ImSpiel == true))
                {
                    if(aS.x+1 <= feldMax_X)
                    {
                        aS.x++;
                    }
                    if (aS.y + 1 <= feldMax_Y)
                    {
                        aS.y++;
                    }
                }

                //! Schicke B-Spieler auf Nachbarfeld
                foreach (B_Spieler bS in bListe.FindAll(b=>b.ImSpiel==true))
                {
                    if (bS.x + 1 <= feldMax_X)
                    {
                        bS.x++;
                    }
                    if (bS.y + 1 <= feldMax_Y)
                    {
                        bS.y++;
                    }
                }

                //! Prüfe ob A-Spieler grüßen müssen
                foreach(A_Spieler aS in aListe.FindAll(a=>a.ImSpiel == true))
                {
                    foreach(A_Spieler aS_2 in aListe.FindAll(a=>a.Name != aS.Name && a.x == aS.x && a.y == aS.y))
                    {
                        aS.Gruessen(aS_2);
                    }
                }

                //! Prüfe ob B-Spieler grüßen müssen
                foreach (B_Spieler bS in bListe.FindAll(b=>b.ImSpiel==true))
                {
                    foreach (B_Spieler bS_2 in bListe.FindAll(b => b.Name != bS.Name && b.x == bS.x && b.y == bS.y))
                    {
                        bS.Gruessen(bS_2);
                    }
                }

                short sieger;
                //! FIGHT!
                foreach(A_Spieler aS in aListe.FindAll(a=>a.ImSpiel==true)) // aListe wird gecheckt da wir irgendwo anfangen müssen #TEAM_A
                {
                    foreach(B_Spieler bS in bListe.FindAll(b=>b.ImSpiel==true).FindAll(b=>aS.x == b.x && aS.y == b.y))
                    {
                        sieger = (short)rnd.Next((short)Sieger.istA, (short)Sieger.istB+1);
                        switch(sieger)
                        {
                            case (short)Sieger.istA:
                                aS.Jubeln();
                                bS.Heulen();
                                bS.ImSpiel = false;
                                break;
                            case (short)Sieger.istB:
                                bS.Jubeln();
                                aS.Heulen();
                                aS.ImSpiel = false;
                                break;
                        }
                    }
                }
            } //end while

            Console.WriteLine("\n------------------------------\n");

            if(aListe.Any(a=>a.ImSpiel == true))
            {
                Console.WriteLine("Team A gewinnt :)");
            }
            else
            {
                Console.WriteLine("Team B gewinnt :)");
            }
            Console.ReadKey();
        }
        
    }
}
