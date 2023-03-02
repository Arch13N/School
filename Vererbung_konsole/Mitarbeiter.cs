using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_konsole
{
    public class Mitarbeiter
    {
        protected string nachname;
        protected string vorname;
        public Mitarbeiter()
        {
            nachname = "-Keine Angabe-";
            vorname = "-Keine Angabe-";
        }
        public Mitarbeiter(string v, string n)
        {
            this.vorname = v;
            this.nachname = n;
        }
        public string getNachname()
        {
            return this.nachname;
        }
        public string getVorname()
        {
            return this.vorname;
        }
        public void setNachname(string n)
        {
            this.nachname = n;
        }
        public void setVorname(string v)
        {
            this.vorname = v;
        }
        public virtual void datenAnzeigen()
        {

        }
    }
}
