using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peksegSzimulator
{
    class Pekseg
    {
        string nev;
        List<Pekaru> aruk = new List<Pekaru>();
        DateTime alapitva;

        public Pekseg(string nev, DateTime alapitva)
        {
            this.nev = nev;
            this.alapitva = alapitva;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva;}
        internal List<Pekaru> Aruk { get => aruk;}

        public override string ToString()
        {
            return string.Format("\"" + this.nev + " - " + this.alapitva+ "\"");
        }
    }
}
