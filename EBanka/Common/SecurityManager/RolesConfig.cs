using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Common.SecurityManager
{
    public enum Roles
    {
        Admin = 0,
        Radnik = 1,
        Korisnik = 2
    }

    public enum Permissions
    {
        DodajRadnika = 0,
        IzmemiRadnika = 1,
        ObrisiRadnika = 2,
        IzmeniProviziju = 3,
        DodajKorisnika = 4,
        IzmeniKorisnika = 5,
        ObrisiKorisnika = 6,
        DodajTransakciju = 7,
        IzmeniTransakciju = 8,
        ObrisiTransakciju = 9,
        ObradaZahtevaZaDM = 10,
        ZahtevZaDozvoljeniMinus = 11
    }

    public class RolesConfig
    {
        private static ResourceManager resourceManager = null;
        private static ResourceSet resourceSet = null;
        private static object resourceLock = new object();

        private static ResourceManager ResourceManager
        {
            get
            {
                lock (resourceLock)
                {
                    if (resourceManager == null)
                        resourceManager = new ResourceManager(typeof(ConFile).FullName, Assembly.GetExecutingAssembly());
                    return resourceManager;
                }
            }
        }

        private static ResourceSet ResourceSet
        {
            get
            {
                lock (resourceLock)
                {
                    if (resourceLock == null)
                        resourceSet = ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, true);
                    return resourceSet;
                }
            }
        }

        public static string[] GetValue(string roleName)
        {
            //skup priviligije za datu rolu
            if (roleName == "Admin")
            {
                return ResourceManager.GetString(Roles.Admin.ToString()).Split(',');
            }
            else if (roleName == "Radnik")
            {
                return ResourceManager.GetString(Roles.Radnik.ToString()).Split(',');
            }
            else
            {
                return ResourceManager.GetString(Roles.Korisnik.ToString()).Split(',');
            }
        }
    }
}