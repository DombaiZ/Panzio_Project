using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public class Ugyfel
    {
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public string Email { get; set; }
        public bool Vip { get; set; }

        public Ugyfel(string nev, DateTime szuletesiDatum, string email, bool vip)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Email = email;
            Vip = vip;
            Azonosito = $"{nev}_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
        }
    }
}
