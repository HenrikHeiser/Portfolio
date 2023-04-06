using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Einführungswoche_Konfigurator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Wie heißt du?");
            string kaeuferName = Console.ReadLine();
            Console.WriteLine("Hallo {0}!", kaeuferName);
            Console.WriteLine("Hallo, " + kaeuferName + " Wasserspender!");
            Console.ReadKey();

            Console.WriteLine(Addition(28, 82));
            Console.WriteLine("Fertig");
            Console.ReadKey();

            string fahrzeugKlasse = "";
            Console.WriteLine("Für welche Fahrzeugklasse interessieren sie sich?");
            Console.WriteLine(" [A] \n [B] \n [C] \n ");
            fahrzeugKlasse = Console.ReadLine();
            Console.ReadKey();

            if (fahrzeugKlasse.ToUpper() == "A")
            {
                Console.WriteLine("Gute Wahl!");
            }
            else if (fahrzeugKlasse.ToUpper() == "B")
            {
                Console.WriteLine("Schlechte Wahl!");
            }
            else if (fahrzeugKlasse.ToUpper() == "C")
            {
                Console.WriteLine("Der Bruder hat Geschmack!");
            }
            else
            {
                Console.WriteLine("Wiederholen sie das bitte!");
            }
            Console.ReadKey();

            Console.Clear();
            Thread.Sleep(1000);
            switch (fahrzeugKlasse)
            {
                case "A":

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ResetColor();

                    Console.WriteLine("AAAAAAAAHHHH");
                    break;
                case "B":
                    Console.WriteLine("BAAAADESALZ");
                    break;
                case "C":
                    Console.WriteLine("c klasse is ganz gut bro");
                    break;
                default:
                    Console.WriteLine("Pech!");
                    break;
            }
            Console.ReadKey();
            */
            Console.WriteLine("Sind Sie bereits Kunde?");
            string Ausgabe = Console.ReadLine();
            bool bereitsKunde = false;
            if (Ausgabe.ToUpper() == "JA")
            {
                Console.WriteLine("Nice, hier nimm Rabatt!");
                bereitsKunde = true;
            }
            else if (Ausgabe.ToUpper() == "NEIN")
            {
                Console.WriteLine("Werd Kunde!");
                bereitsKunde = false;
            }
            else
            {
                Console.WriteLine("Wiederholen Sie das bitte!");

            }
            Console.ReadKey();
            Console.Clear();

        }

        static int Addition(int a, int b)
        {
            int ergebnis = a + b;
            return ergebnis;
        }
    }
}
