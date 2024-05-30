using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public class Szoba
    {
        public int Szobaszam { get; set; }
        public int Ferohelyek { get; set; }
        public decimal Ar { get; set; }

        public Szoba(int szobaszam, int ferohelyek, decimal ar)
        {
            Szobaszam = szobaszam;
            Ferohelyek = ferohelyek;
            Ar = ar;
        }
    }
}
