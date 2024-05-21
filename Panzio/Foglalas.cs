using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public class Foglalas
    {
        int szobaszam;
        int ferohely;
        int ar;

        public Foglalas(int szobaszam, int ferohely, int ar)
        {
            this.Szobaszam = szobaszam;
            this.Ferohely = ferohely;
            this.Ar = ar;
        }

        public int Szobaszam { get => szobaszam; set => szobaszam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar = value; }
    }
}
