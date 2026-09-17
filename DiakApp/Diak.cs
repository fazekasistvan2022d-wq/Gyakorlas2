using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public double Atlag { get; set;  }
        public Diak()
        {
            Nev = "Kiss Péter";
            Atlag = 4.5;
        }
        public Diak(string nev, double atlag)
        {
            Nev = nev;
            Atlag = atlag;
        }
    }
}
