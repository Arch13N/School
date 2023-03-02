using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter[] Alle = new Mitarbeiter[4];
            Angestellter A1 = new Angestellter("Vorname", "Nachname", 10);
            Angestellter A2 = new Angestellter();
            Arbeiter AR1 = new Arbeiter("Vor", "Nach", 8, 10);
            Arbeiter AR2 = new Arbeiter();

            //Eingabe A2
            Console.WriteLine("\n\n\t\t***Angestellter 2***");
            Console.Write("Bitte Vorname Angestellter1: ");
            A2.setVorname(Console.ReadLine());
            Console.Write("Bitte Nachname Angestellter1: ");
            A2.setNachname(Console.ReadLine());
            Console.Write("Bitte Brutto Angestellter1: ");
            A2.setBrutto(Convert.ToDouble(Console.ReadLine()));

            //Eingabe AR2
            Console.WriteLine("\n\n\n\t\t***Arbeiter 2***");
            Console.Write("Bitte Vorname Arbeiter2: ");
            AR2.setVorname(Console.ReadLine());
            Console.Write("Bitte Nachname Arbeiter2: ");
            AR2.setNachname(Console.ReadLine());
            Console.Write("Bitte Stunden Arbeiter2: ");
            AR2.setStunden(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Bitte Lohn Arbeiter2: ");
            AR2.setStundenLohn(Convert.ToDouble(Console.ReadLine()));

            Alle[0] = A1;
            Alle[1] = A2;
            Alle[2] = AR1;
            Alle[3] = AR2;

            //Console.WriteLine("\n\n\n***Angestellte***");
            //A1.datenAnzeigen();
            //A2.datenAnzeigen();
            Console.Write("\n\n\n\n\t\t\t\t***Ausgabe***");
            for (int i = 0; i < Alle.Length; i++)
            {
                Alle[i].datenAnzeigen();
            }
            //Console.WriteLine("\n\n\n***Arbeiter***");
            //AR1.datenAnzeigen();
            //AR2.datenAnzeigen();

            Console.ReadKey();
        }
    }
}
