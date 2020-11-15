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

        public int ar(int szam)
        {
            return this.Aruk.ElementAt(szam).Ar;
        }

        public int kereso(int melyik)
        {
            int index = 0;
            if (melyik == 1){
                int max = this.Aruk.ElementAt(0).Ar;
                for (int i = 1; i < this.aruk.Count; i++)
                {
                    if (this.Aruk.ElementAt(i).Ar > max)
                    {
                        max = Aruk.ElementAt(i).Ar;
                        index = i;
                    }
                }
                return index;
            } else{
                int min = this.Aruk.ElementAt(0).Ar;
                for (int i = 1; i < this.aruk.Count; i++)
                {
                    if (this.Aruk.ElementAt(i).Ar < min)
                    {
                        min = Aruk.ElementAt(i).Ar;
                        index = i;
                    }
                }
                return index;
            }
        }

        public int oszegzo()
        {
            int osszeg = 0;
            for (int i = 0; i < this.Aruk.Count; i++)
            {
                if (this.Aruk.ElementAt(i).Laktozmentes)
                {
                    osszeg++;
                };
            }
            return osszeg;
        }

        public bool vanLaktozmentesTermek()
        {
            for (int i = 0; i < this.Aruk.Count; i++)
            {
                if (this.Aruk.ElementAt(i).Laktozmentes)
                {
                    return true;
                };
            }
            return false;
        }

        public double szazalek(int x)
        {
            double max = this.Aruk.Count();
            return (x/ max)*100;
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
