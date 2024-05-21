using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    internal class Szallas
    {
        int ugyfelID;
        string ugyfelNev;
        TimeSpan szulEv;
        string email;
        bool ugyfelVIP;

        public Szallas(int ugyfelID, string ugyfelNev, TimeSpan szulEv, string email, bool ugyfelVIP)
        {
            this.UgyfelID = ugyfelID;
            this.UgyfelNev = ugyfelNev;
            this.SzulEv = szulEv;
            this.Email = email;
            this.UgyfelVIP = ugyfelVIP;
        }

        public override string ToString()
        {
            return $"{ugyfelID};{ugyfelNev},{szulEv},{email},{ugyfelVIP}\n";
        }

        public int UgyfelID { get => ugyfelID; set => ugyfelID = value; }
        public string UgyfelNev { get => ugyfelNev; set => ugyfelNev = value; }
        public TimeSpan SzulEv { get => szulEv; set => szulEv = value; }
        public string Email { get => email; set => email = value; }
        public bool UgyfelVIP { get => ugyfelVIP; set => ugyfelVIP = value; }
    }
}
