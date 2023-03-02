using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_konsole
{
    public class Arbeiter : Mitarbeiter
    {
        private int stunden;
        private double stdLohn;
        
        public Arbeiter() : base()
        {
            Console.WriteLine("Standardkonstruktor Arbeiter");
            this.stunden = 0;
            this.stdLohn = 0;
        }
        public Arbeiter(string v, string n, int std, int stdLohn) : base(v, n)
        {
            Console.WriteLine("Überladener Konstruktor Arbeiter");
            this.stunden = std;
            this.stdLohn = stdLohn;
        }
        public double berechneBrutto()
        {
            return this.stdLohn * this.stunden;
        }
        public void setStunden(int std)
        {
            this.stunden = std;
        }
        public void setStundenLohn(double stdLohn)
        {
            this.stdLohn = stdLohn;
        }
        public override void datenAnzeigen()
        {
            //Ausgabe Arbeiter
            Console.Write("\nArbeiter: {0} {1}, verdient {2}", this.getVorname(), this.getNachname(), this.berechneBrutto());
        }
    }
}
