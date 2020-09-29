using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._09._29_SZFGY
{
    class Program
    {
        static void Main(string[] args)
        {
            //bankjegyautomata
            Console.WriteLine("Bankjegyautomata");
            Console.WriteLine("A legkisebb címlet 1000 Ft, a maximálisan felvehető összeg 300 000 Ft");
            Console.Write("Adja meg mekkora összeget kiván felvenni! ");
            int osszeg = Convert.ToInt32(Console.ReadLine());
            int tizezer = 0;
            int otezer = 0;
            int ezer = 0;
            int osszegketto = osszeg;
            if (osszeg%1000==0&&osszeg<=300000)
            {
               
                    tizezer = osszeg / 10000;
                    osszeg = osszeg-(tizezer * 10000);
                    otezer = osszeg / 5000;
                    osszeg = osszeg - (otezer*5000);
                    ezer = osszeg / 1000;
                Console.WriteLine(tizezer + " * 10000 = " + (tizezer * 10000));
                Console.WriteLine(otezer + " * 5000 = " + (otezer * 5000));
                Console.WriteLine(ezer + " * 1000 = " + (ezer * 1000));
                Console.WriteLine("Összeg: "+osszegketto+" Ft");

            }
            else if (osszeg%1000!=0)
            {
                Console.WriteLine("Az összeg nem felvehető");
            }                      
                
            Console.ReadKey();
            Console.Clear();


            //Utazási költségtérítés
            Console.WriteLine("Utazási költségtérítés");
            Console.WriteLine();
            Console.Write("Add meg a megtett utat km-ben! ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az autó fogyasztását 100 km-re literben! ");
            double fogyasztas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg az üzemanyagárat ft-ban! ");
            double uzemanyagar = Convert.ToDouble(Console.ReadLine());
            double uzemanyagkoltseg = (km * fogyasztas * uzemanyagar) / 100;
            if (km<100)
            {
                Console.WriteLine("Költségtérítés: "+uzemanyagkoltseg+" ft");
            }
            else
            {
                Console.WriteLine("Költségtérítés: "+(uzemanyagkoltseg+(km*25))+" ft");
            }
            Console.ReadKey();
            Console.Clear();


            //Testtömegindex
            Console.WriteLine("Testtömegindex");
            Console.Write("Add meg a tömeged kg-ba! ");
            double tomeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a magasságod cm-ben! ");
            double magassag = (Convert.ToDouble(Console.ReadLine())/100);
            double TTI =tomeg/(magassag*magassag) ;
            Console.WriteLine("A testtömegindexed: "+TTI);
            Console.ReadLine();
        }
    }
}
