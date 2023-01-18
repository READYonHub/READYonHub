using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapirollo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string pc = "";
            string jatekos = "";
            int pcpont = 0, jatekospont = 0;
            ConsoleKeyInfo gomb = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Mit választasz? k/p/o (kilépés ESC billentyűzetre)");
                gomb = Console.ReadKey(true);
                switch(gomb.KeyChar)
                {
                    case 'k':
                        jatekos = "kő";
                        break;
                    case 'p':
                        jatekos = "papir";
                        break;
                    case 'o':
                        jatekos = "olló";
                        break;
                }
                switch (rnd.Next(0,3))
                {
                    case 0:
                        pc = "kő";
                        break;
                    case 1:
                        pc = "papir";
                        break;
                    case 2:
                        pc = "olló";
                        break;
                }
                Console.WriteLine("Számitógép: {0}, játékos: {1}", pc,jatekos);
                if((jatekos == "kő" && pc == "papir") || (jatekos=="papir" && pc=="olló") || (jatekos=="olló" && pc=="kő"))
                {
                    pcpont++;
                    Console.WriteLine("vesztettél! Az állás: számitógép: {0}    játékos: {1}",pcpont,jatekospont);
                }
                else if (pc == jatekos)
                {
                    Console.WriteLine("Döntetlen");
                }
                else
                {
                    jatekospont++;
                    Console.WriteLine("Nyertél! Az állás: számitógép: {0}    játékos: {1}", pcpont, jatekospont);
                }
            } while(gomb.Key!=ConsoleKey.Escape); 
        }
    }
}
