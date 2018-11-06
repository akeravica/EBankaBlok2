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
        string prezime ;
        int brojRacuna;
        float dozvoljeniMinus;
        float novcanaSredstva;
        List<Transakcija> transakcije = new List<Transakcija>();

        public Korisnik()
        {
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
        [DataMember]
        public int BrojRacuna
        {
            get => brojRacuna;
            set => brojRacuna = value;
        }
        [DataMember]
        public float DozvoljeniMinus
        {
            get => dozvoljeniMinus;
            set => dozvoljeniMinus = value;
        }

        [DataMember]
        public float NovcanaSredstva
        {
            get => novcanaSredstva;
            set => novcanaSredstva = value;
        }

        [DataMember]
        public List<Transakcija> Transakcije
        {
            get => transakcije;
            set => transakcije = value;
        }
    }
}
