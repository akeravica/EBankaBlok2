using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Admin
    {
        string korisnickoIme;
        string sifra = String.Empty;
        string ime;
        string prezime;

        public Admin()
        {
        }

        public Admin(string k, string s, string i, string p)
        {
            this.korisnickoIme = k;
            this.sifra = s;
            this.ime = i;
            this.prezime = p;
        }
        [DataMember]
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }
        [DataMember]
        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        [DataMember]
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        [DataMember]
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
    }
}
