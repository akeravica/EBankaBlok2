using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IOperacije
    { 
        [OperationContract]
        bool DodajRadnika(string korisnickoIme, string sifra, string ime, string prezime);

        [OperationContract]
        bool IzmeniRadnika(string korisnickoIme, string sifra, string ime, string prezime);

        [OperationContract]
        string ObrisiRadnika(string korisnickoIme);

        [OperationContract]
        bool IzmeniProviziju(int novaProvizija);

        [OperationContract]
        bool DodajKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva);

        [OperationContract]
        bool IzmeniKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva, float dozvoljeniMinus); // fali transakcija....

        [OperationContract]
        string ObrisiKorisnika(string korisnickoIme);

        [OperationContract]
        bool DodajTransakciju(int brojRacuna, int idTransakcije, float iznos);

        [OperationContract]
        bool IzmeniTransakciju(int brojRacuna, int idTransakcije, float iznos);

        [OperationContract]
        string ObrisiTransakciju(int brojRacuna, int idTransakcije);

        [OperationContract]
        bool ZahtevZaDozvoljeniMinus();
    }
}
