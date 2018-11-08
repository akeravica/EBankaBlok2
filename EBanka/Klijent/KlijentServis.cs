using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klijent
{
    public class KlijentServis : ChannelFactory<IOperacije>, IOperacije, IDisposable
    {
        IOperacije factory;

        public KlijentServis(NetTcpBinding binding, EndpointAddress address)
            : base(binding, address)
        {
            //IPrincipal principal = Thread.CurrentPrincipal;
            //WindowsIdentity id = (WindowsIdentity)principal.Identity;
            //IdentityReferenceCollection clGroups = id.Groups;

            IdentityReferenceCollection clGroups = WindowsIdentity.GetCurrent().Groups;
            string groupName = "";
            foreach (IdentityReference group in clGroups)
            {
                SecurityIdentifier sid = (SecurityIdentifier)group.Translate(typeof(SecurityIdentifier));
                var name = sid.Translate(typeof(NTAccount));
                groupName = Formatter.ParseName(name.ToString());    /// return name of the Windows group				
                if (groupName == "admini" || groupName == "radnik" || groupName == "korisnik")
                {
                    break;
                }
            }

            factory = this.CreateChannel();
        }

        public bool DodajKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva)
        {
            try
            {
                return factory.DodajKorisnika(korisnickoIme, sifra, ime, prezime, brojRacuna, novcanaSredstva);
            }
            catch (Exception e)
            {
                Console.WriteLine("[DodajKorisnika] Error={0}", e.Message);
                return false;
            }
        }

        public bool DodajRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            try
            {
                return factory.DodajRadnika(korisnickoIme, sifra, ime, prezime);
            }
            catch (Exception e)
            {
                Console.WriteLine("[DodajRadnika] Error={0}", e.Message);
                return false;
            }
        }

        public bool DodajTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            try
            {
                return factory.DodajTransakciju(brojRacuna, idTransakcije, iznos);
            }
            catch (Exception e)
            {
                Console.WriteLine("[DodajTransakciju] Error={0}", e.Message);
                return false;
            }
        }

        public bool IzmeniKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva, float dozvoljeniMinus)
        {
            try
            {
                return factory.IzmeniKorisnika(korisnickoIme, sifra, ime, prezime, brojRacuna, novcanaSredstva, dozvoljeniMinus);
            }
            catch (Exception e)
            {
                Console.WriteLine("[IzmeniKorisnika] Error={0}", e.Message);
                return false;
            }
        }

        public bool IzmeniProviziju(int novaProvizija)
        {
            try
            {
                return factory.IzmeniProviziju(novaProvizija);
            }
            catch (Exception e)
            {
                Console.WriteLine("[IzmeniProviziju] Error={0}", e.Message);
                return false;
            }
        }

        public bool IzmeniRadnika(string korisnickoIme, string sifra, string ime, string prezime)
        {
            try
            {
                return factory.IzmeniRadnika(korisnickoIme, sifra, ime, prezime);
            }
            catch (Exception e)
            {
                Console.WriteLine("[IzmeniRadnika] Error={0}", e.Message);
                return false;
            }
        }

        public bool IzmeniTransakciju(int brojRacuna, int idTransakcije, float iznos)
        {
            try
            {
                return factory.IzmeniTransakciju(brojRacuna, idTransakcije, iznos);
            }
            catch (Exception e)
            {
                Console.WriteLine("[IzmeniTransakciju] Error={0}", e.Message);
                return false;
            }
        }

        public string ObrisiKorisnika(string korisnickoIme)
        {
            try
            {
                return factory.ObrisiKorisnika(korisnickoIme);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ObrisiKorisnika] Error={0}", e.Message);
                return "";
            }
        }

        public string ObrisiRadnika(string korisnickoIme)
        {
            try
            {
                return factory.ObrisiRadnika(korisnickoIme);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ObrisiRadnika] Error={0}", e.Message);
                return "";
            }
        }

        public string ObrisiTransakciju(int brojRacuna, int idTransakcije)
        {
            try
            {
                return factory.ObrisiTransakciju(brojRacuna, idTransakcije);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ObrisiTransakciju] Error={0}", e.Message);
                return "";
            }
        }

        public bool ZahtevZaDozvoljeniMinus()
        {
            try
            {
                return factory.ZahtevZaDozvoljeniMinus();
            }
            catch (Exception e)
            {
                Console.WriteLine("[ZahtevZaDozvoljeniMinus] Error={0}", e.Message);
                return false;
            }
        }
    }
}