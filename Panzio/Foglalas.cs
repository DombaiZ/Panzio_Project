using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public class Foglalas
    {
        public Szoba Szoba { get; set; }
        public Ugyfel Ugyfel { get; set; }
        public DateTime ErkezesDatum { get; set; }
        public DateTime TavozasDatum { get; set; }
        public int Letszam { get; set; }
        public decimal Ar { get; set; }
        public string Allapot { get; set; }

        public Foglalas(Szoba szoba, Ugyfel ugyfel, DateTime erkezesDatum, DateTime tavozasDatum, int letszam)
        {
            Szoba = szoba;
            Ugyfel = ugyfel;
            ErkezesDatum = erkezesDatum;
            TavozasDatum = tavozasDatum;
            Letszam = letszam;
            Allapot = "előjegyzett";
            Ar = letszam * szoba.Ar * (tavozasDatum - erkezesDatum).Days;
            if (ugyfel.Vip)
            {
                Ar *= 0.97m; // 3% kedvezmény
            }
        }
    }
}
