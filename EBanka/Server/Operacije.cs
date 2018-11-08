using Common;
using Common.SecurityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Server
{
    public class Operacije : IOperacije
    {
        public bool DodajKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva)
        {
            CustomPrincipal principal = Thread.CurrentPrincipal as CustomPrincipal;
            Korisnik noviKorisnik = new Korisnik(korisnickoIme, sifra, ime, prezime, brojRacuna, novcanaSredstva);
            //Korisnik pronadjiKorisnika = FindUserName(korisnickoIme);
            //prvo provera da li ima prms da doda novog korisnikia
            // da li postouji korisnik sa takvim korisnickim imenom..
            if (principal.IsInRole(Permissions.DodajKorisnika.ToString()))
            {
                if(pronadjiKorisnika == null)
                {
                    // da li postoji fajl pre nego sto kreiras...
                    // ako ne postoji kreiraj novi 
                    //ako postoji onda pisi u tom..
                    using(XmlWriter writer = XmlWriter.Create("Korisnici.xml"))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Korisnik");

                        writer.WriteAttributeString("Korisnicko ime", korisnickoIme);
                        writer.WriteAttributeString("sifra", sifra);
                        writer.WriteAttributeString("Ime", ime);
                        writer.WriteAttributeString("Prezime", prezime);
                        writer.WriteAttributeString("Broj racuna", brojRacuna.ToString());
                        writer.WriteAttributeString("Novcana sredstva", novcanaSredstva.ToString());

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                }    
            }
            else
            {
                Console.WriteLine("Nemate dozvolu da dodate korisnika {0}!",principal.Identity.Name);
                //neuspesna autorizacija -- beleziti u Event logu
            }


            return false;
        }

        public bool DodajRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            throw new NotImplementedException();
        }

        public bool DodajTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            throw new NotImplementedException();
        }

        public bool IzmeniKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva, float dozvoljeniMinus)
        {
            throw new NotImplementedException();
        }

        public bool IzmeniProviziju(int novaProvizija)
        {
            throw new NotImplementedException();
        }

        public bool IzmeniRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            throw new NotImplementedException();
        }

        public bool IzmeniTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            throw new NotImplementedException();
        }

        public string ObrisiKorisnika(string korisnickoIme)
        {
            throw new NotImplementedException();
        }

        public string ObrisiRadnika(string korisnickoIme)
        {
            throw new NotImplementedException();
        }

        public string ObrisiTransakciju(int brojRacuna, int idTransakcije)
        {
            throw new NotImplementedException();
        }

        public bool ZahtevZaDozvoljeniMinus()
        {
            throw new NotImplementedException();
        }
    }
}
