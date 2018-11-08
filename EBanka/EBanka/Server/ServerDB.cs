using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerDB
    {
        public static readonly Dictionary<string, Admin> admini = new Dictionary<string, Admin>();
        public static readonly Dictionary<string, Radnik> radnici = new Dictionary<string, Radnik>();
        public static readonly Dictionary<int, Korisnik> korisnici = new Dictionary<int, Korisnik>();

        static ServerDB()
        {
            Admin admin = new Admin("admin", "1234", "Admin", "Admin");
            ServerDB.admini[admin.KorisnickoIme] = admin;
        }

    }
}
