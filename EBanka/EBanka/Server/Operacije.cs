﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Operacije : IOperacije
    {
        public void DodajKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva)
        {
            throw new NotImplementedException();
        }

        public void DodajRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            throw new NotImplementedException();
        }

        public void DodajTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            throw new NotImplementedException();
        }

        public void IzmeniKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva, float dozvoljeniMinus)
        {
            throw new NotImplementedException();
        }

        public void IzmeniProviziju(int novaProvizija)
        {
            throw new NotImplementedException();
        }

        public void IzmeniRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            throw new NotImplementedException();
        }

        public void IzmeniTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            throw new NotImplementedException();
        }

        public void ObrisiKorisnika(string korisnickoIme)
        {
            throw new NotImplementedException();
        }

        public void ObrisiRadnika(string korisnickoIme)
        {
            throw new NotImplementedException();
        }

        public void ObrisiTransakciju(int brojRacuna, int idTransakcije)
        {
            throw new NotImplementedException();
        }

        public bool ZahtevZaDozvoljeniMinus()
        {
            throw new NotImplementedException();
        }
    }
}
