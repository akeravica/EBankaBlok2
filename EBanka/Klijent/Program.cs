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
            int opcija;
            string korisnickoIme, sifra;
            using (KlijentServis proxy = new KlijentServis(binding, new EndpointAddress(new Uri(address))))
            {
                

                do
                {
                    Console.WriteLine("Prijavite se kao: ");
                    Console.WriteLine("1. Admin");
                    Console.WriteLine("2. Radnnik");
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

                            break;
                        case 2:
                            break;
                        case 3:
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
