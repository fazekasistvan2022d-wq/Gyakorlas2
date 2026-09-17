using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DiakToString
{
    internal class Diak
    {
        public string Nev { get; set; }
        public double Atlag { get; set; }
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

        public override string ToString()
        {
            return $"Név: {Nev}, Átlag: {Atlag}";
        }
    }
}
