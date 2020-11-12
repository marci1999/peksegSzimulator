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

        public Pekseg(string nev,DateTime alapitva)
        {
            this.nev = nev;

            this.alapitva = alapitva;
        }

        public void listahozAdd(Pekaru adotAru)
        {
            this.aruk.Add(adotAru);
        }

        public void lisaElemTorlese(Pekaru adotAru)
        {
            this.aruk.Remove(adotAru);
        }

        public Pekaru listaKiIras(int i) 
        {
            return this.Aruk.ElementAt(i);
        } 

        public int szamol()
        {
            return this.Aruk.Count;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva;}
        internal List<Pekaru> Aruk { get => aruk;}

        public override string ToString()
        {
            return string.Format("\"" + this.nev + " - " + this.alapitva.ToString("yyyy. MM. dd") + "\"");
        }
    }
}
