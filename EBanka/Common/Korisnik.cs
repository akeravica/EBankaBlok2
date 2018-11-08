using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Korisnik
    {
        string korisnickoIme;
        string sifra = String.Empty;
        string ime;
        string prezime;
        int brojRacuna;
        float dozvoljeniMinus;
        float novcanaSredstva;
        List<Transakcija> transakcije = new List<Transakcija>();

        public Korisnik()
        {
        }

        public Korisnik(string k, string s, string i, string p, int br, float ns)
        {
            this.korisnickoIme = k;
            this.sifra = s;
            this.ime = i;
            this.prezime = p;
            this.brojRacuna = br;
            this.novcanaSredstva = ns;
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
        [DataMember]
        public int BrojRacuna
        {
            get { return brojRacuna; }
            set { brojRacuna = value; }
        }
        [DataMember]
        public float DozvoljeniMinus
        {
            get { return dozvoljeniMinus; }
            set { dozvoljeniMinus = value; }
        }

        [DataMember]
        public float NovcanaSredstva
        {
            get { return novcanaSredstva; }
            set { novcanaSredstva = value; }
        }

        [DataMember]
        public List<Transakcija> Transakcije
        {
            get { return transakcije; }
            set { transakcije = value; }
        }
    }
}