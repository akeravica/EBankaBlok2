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
        void DodajRadnika(string korisnickoIme, string sifra, string ime, string prezime);

        [OperationContract]
        void IzmeniRadnika(string korisnickoIme, string sifra, string ime, string prezime);

        [OperationContract]
        void ObrisiRadnika(string korisnickoIme);

        [OperationContract]
        void IzmeniProviziju(int novaProvizija);

        [OperationContract]
        void DodajKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva);

        [OperationContract]
        void IzmeniKorisnika(string korisnickoIme, string sifra, string ime, string prezime, int brojRacuna, float novcanaSredstva, float dozvoljeniMinus); // fali transakcija....

        [OperationContract]
        void ObrisiKorisnika(string korisnickoIme);

        [OperationContract]
        void DodajTransakciju(int brojRacuna, int idTransakcije, float iznos);

        [OperationContract]
        void IzmeniTransakciju(int brojRacuna, int idTransakcije, float iznos);

        [OperationContract]
        void ObrisiTransakciju(int brojRacuna, int idTransakcije);

        [OperationContract]
        bool ZahtevZaDozvoljeniMinus();
    }
}
