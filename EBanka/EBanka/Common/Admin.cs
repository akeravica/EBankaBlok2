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

        public Admin(string k, string i, string s, string p)
        {
            this.korisnickoIme = k;
            this.sifra = i;
            this.ime = s;
            this.prezime = p;
        }
        [DataMember]
        public string KorisnickoIme
        {
            get => korisnickoIme;
            set => korisnickoIme = value;
        }
        [DataMember]
        public string Sifra
        {
            get => sifra;
            set => sifra = value;
        }
        [DataMember]
        public string Ime
        {
            get => ime;
            set => ime = value;
        }
        [DataMember]
        public string Prezime
        {
            get => prezime;
            set => prezime = value;
        }
    }
}
