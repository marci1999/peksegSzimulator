﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peksegSzimulator
{
    class Pekaru
    {
        string nev;
        int ar;
        bool laktozmentes;

        public Pekaru(string nev, int ar, bool laktozmentes)
        {
            this.nev = nev;
            this.ar = ar;
            this.laktozmentes = laktozmentes;
        }

        public string Nev { get => nev; set => nev = value;}
        public int Ar { get => ar; set => ar = value;}
        public bool Laktozmentes { get => laktozmentes; set => laktozmentes = value; }

        public override string ToString()
        {
            return string.Format("\""+this.nev+" ("+this.ar+" FT/ db)\""+"");
        }
    }
}
