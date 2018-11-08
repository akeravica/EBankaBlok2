using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding binding = new NetTcpBinding();
            string address = "net.tcp://localhost:9999/Operacije";
            int opcija, opcijaRadnik, opcijaKorisnik;
            string korisnickoIme, sifra;
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
                            Console.WriteLine("Unesite vase korisnicko ime: ");
                            korisnickoIme = Console.ReadLine();
                            Console.WriteLine("Unesite vasu sifru: ");
                            sifra = Console.ReadLine();
                            //CheckPassword i ResetPassword
                            do
                            {
                                Console.WriteLine("Izaberite opciju: ");
                                Console.WriteLine("1. Dodajte radnika");
                                Console.WriteLine("2. Promeni radnikove podatke");
                                Console.WriteLine("3. Izbrisi radnika");
                                Console.WriteLine("4. Promeni iznos provizije");
                                Console.WriteLine("5. Exit");

                                opcijaRadnik = Convert.ToInt32(Console.ReadLine());

                                switch(opcijaRadnik)
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

                            break;
                        case 4:
                            break;
                    }
                } while (opcija != 4);
            }
            Console.ReadLine();
        }
    }
}
