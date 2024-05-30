using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public static class Adatforras
    {
        public static List<Foglalas> Foglalasok { get; set; } = new List<Foglalas>();
        public static List<Ugyfel> Ugyfelek { get; set; } = new List<Ugyfel>();
        public static List<Szoba> Szobak { get; set; } = new List<Szoba>
        {
            new Szoba(1, 2, 6000),
            new Szoba(2, 3, 7000),
            new Szoba(3, 4, 8000),
            new Szoba(4, 2, 9000),
            new Szoba(5, 3, 10000),
            new Szoba(6, 4, 12000)
        };
    }
}
