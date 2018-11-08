using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Common;
using System.Threading;

namespace Klijent
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrincipal principal = Thread.CurrentPrincipal;
            WindowsIdentity id = (WindowsIdentity)principal.Identity;

            IdentityReferenceCollection clGroups = id.Groups;
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

            NetTcpBinding binding = new NetTcpBinding();

            //if (!found)
            //{
            //    Console.WriteLine("Klijent nije ni u jednoj od grupa.");
            //    Console.ReadLine();
            //}
            //else
            //{
            string address = "net.tcp://localhost:9999/Operacije";
            int opcija, opcijaRadnik, opcijaKorisnik, opcijaDM;
            string korisnickoIme, sifra, korisnickoIme1, sifra1 = String.Empty;
            using (KlijentServis proxy = new KlijentServis(binding, new EndpointAddress(new Uri(address))))
            {
                do
                {
                    Console.WriteLine("Prijavite se kao: ");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Radnik");
                    Console.WriteLine("3. Korisnik");
                    Console.WriteLine("4. Exit");

                    opcija = Convert.ToInt32(Console.ReadLine());

                    switch (opcija)
                    {
                        case 1:
                            Console.Write("Unesite vase korisnicko ime: ");
                            korisnickoIme = Console.ReadLine();
                            Console.Write("Unesite vasu sifru: ");
                            sifra = Console.ReadLine();

                            using (StreamReader sr = new StreamReader(File.Open("C:\\Users\\NanaPC\\Downloads\\EBankaBlok2-master\\EBanka\\Admin.txt", FileMode.Open)))
                            {
                                korisnickoIme1 = sr.ReadLine();
                                sifra1 = sr.ReadLine();
                            }

                            if (korisnickoIme == korisnickoIme1 && sifra == sifra1)
                            {
                                Console.WriteLine("Uspesno logovanje!");
                                do
                                {
                                    Console.WriteLine("Izaberite opciju: ");
                                    Console.WriteLine("1. Dodajte radnika");
                                    Console.WriteLine("2. Promeni radnikove podatke");
                                    Console.WriteLine("3. Izbrisi radnika");
                                    Console.WriteLine("4. Promeni iznos provizije");
                                    Console.WriteLine("5. Exit");

                                    opcijaRadnik = Convert.ToInt32(Console.ReadLine());

                                    switch (opcijaRadnik)
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                        case 4:
                                            break;
                                        case 5:
                                            break;
                                    }
                                } while (opcijaRadnik != 5);
                            }
                            else
                            {
                                Console.WriteLine("Neuspesno logovanje!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Unesite vase korisnicko ime: ");
                            korisnickoIme = Console.ReadLine();
                            Console.WriteLine("Unesite vasu sifru: ");
                            sifra = Console.ReadLine();
                            //CheckPassword i ResetPassword
                            do
                            {
                                Console.WriteLine("Izaberite opciju: ");
                                Console.WriteLine("1. Dodajte korisnika");
                                Console.WriteLine("2. Promeni korisnikove podatke");
                                Console.WriteLine("3. Izbrisi korisnika");
                                Console.WriteLine("4. Dodajte transakciju za korisnika");
                                Console.WriteLine("5. Izmenite korisnikove transakciju");
                                Console.WriteLine("6. Izbrisite korisnikove transakcije");
                                Console.WriteLine("7. Dozvoljeni minusi");
                                Console.WriteLine("8. Exit");

                                opcijaKorisnik = Convert.ToInt32(Console.ReadLine());

                                switch (opcijaKorisnik)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;
                                    case 4:
                                        break;
                                    case 5:
                                        break;
                                    case 6:
                                        break;
                                    case 7:
                                        break;
                                    case 8:
                                        break;
                                }
                            } while (opcijaKorisnik != 8);
                            break;
                        case 3:
                            Console.WriteLine("Unesite vase korisnicko ime: ");
                            korisnickoIme = Console.ReadLine();
                            Console.WriteLine("Unesite vasu sifru: ");
                            sifra = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("1. Zahtev za dozvoljeni minus");
                                Console.WriteLine("2. Exit");

                                opcijaDM = Convert.ToInt32(Console.ReadLine());

                                switch (opcijaDM)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                }
                            } while (opcijaDM != 2);
                            break;
                        case 4:
                            break;
                    }
                } while (opcija != 4);
            }
            //}
            Console.ReadLine();
        }
    }
}
