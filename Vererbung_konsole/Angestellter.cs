using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_konsole
{
    public class Angestellter : Mitarbeiter
    {
        private double brutto;
        public Angestellter() : base()
        {
            this.brutto = 0;
        }
        public Angestellter(string v, string n, double b) : base(v, n)
        {
            this.brutto = b;
        }
        public double getBrutto()
        {
            return this.brutto;
        }
        public void setBrutto(double b)
        {
            this.brutto = b;
        }
        public override void datenAnzeigen()
        {
            //Ausgabe Angestellte
            Console.Write("\nAngestellter: {0} {1}, verdient {2}", this.getVorname(), this.getNachname(), this.getBrutto());
        }
    }
}
