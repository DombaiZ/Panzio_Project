using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panzio
{
    public class Ugyfel
    {
        string ugyfelID;
        string ugyfelNev;
        DateTime szulEv;
        string email;
        bool ugyfelVIP;

        public Ugyfel(string ugyfelID, string ugyfelNev, DateTime szulEv, string email, bool ugyfelVIP)
        {
            this.UgyfelID = ugyfelID;
            this.UgyfelNev = ugyfelNev;
            this.SzulEv = szulEv;
            this.Email = email;
            this.UgyfelVIP = ugyfelVIP;
        }

        public override string ToString()
        {
            return $"{ugyfelID};{ugyfelNev},{szulEv.Year},{szulEv.Month},{szulEv.Day},{email},{ugyfelVIP}\n";
        }

        public string UgyfelID { get => ugyfelID; set => ugyfelID = value; }
        public string UgyfelNev { get => ugyfelNev; set => ugyfelNev = value; }
        public DateTime SzulEv { get => szulEv; set => szulEv = value; }
        public string Email { get => email; set => email = value; }
        public bool UgyfelVIP { get => ugyfelVIP; set => ugyfelVIP = value; }
    }
}
