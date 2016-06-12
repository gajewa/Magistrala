using System;
using System.Collections.Generic;

namespace MagistralaPocztowa
{
   public class Magazyn
    {
        private List<Przesylka> Przesylki;
        public int TerazId { get; set; } = 1;

        public Magazyn()
        {
            this.Przesylki = new List<Przesylka>
            {
                new Paczka()
                {
                    Nadawca = "Mateusz",
                    AdresNadawacy = "Gradowa 19, 81-577",
                    Odbiorca = "Kasia",
                    AdresOdbiorcy = "Stolarska 1, 81-826",
                    Priorytet = true,
                    Typ = "paczka",
                    Ubezpieczenie = true,
                    Waga = 12,
                    WymiarX = 12,
                    WymiarY = 12,
                    WymiarZ = 12,
                    Id = TerazId++,
                    TrackingNumber = 132

                },
                new Paczka()
                {
                    Nadawca = "Mateusz",
                    AdresNadawacy = "Gradowa 19, 81-577",
                    Odbiorca = "Kasia",
                    AdresOdbiorcy = "Stolarska 1, 81-826",
                    Priorytet = true,
                    Typ = "paczka",
                    Ubezpieczenie = true,
                    Waga = 12,
                    WymiarX = 12,
                    WymiarY = 12,
                    WymiarZ = 12,
                    Id = TerazId++,
                    TrackingNumber = 421

                },
                new Paczka()
                {
                    Nadawca = "Mateusz",
                    AdresNadawacy = "Gradowa 19, 81-577",
                    Odbiorca = "Kasia",
                    AdresOdbiorcy = "Stolarska 1, 81-826",
                    Priorytet = true,
                    Typ = "paczka",
                    Ubezpieczenie = true,
                    Waga = 12,
                    WymiarX = 12,
                    WymiarY = 12,
                    WymiarZ = 12,
                    Id = TerazId++,
                    TrackingNumber = 241
                }
            };
        }

        public void DodajPozycje()
        {
            Console.WriteLine("Jaki typ przesylki chcesz wprowadzic?");
            Console.WriteLine("1 - List");
            Console.WriteLine("2 - Paczka");
            Console.WriteLine("3 - Przesylka specjalna");

            int opcja = int.Parse(Console.ReadLine());

            switch (opcja)
            {
                case 1:
                    DodajList();
                    break;
                case 2:
                    DodajPaczke();
                    break;
                case 3:
                    DodajSpecjalne();
                    break;
                default:
                    Console.WriteLine("Zla opcja, nie udalo sie wprowadzic paczki");
                    break;
            }
        }

        private void DodajList()
        {
            List nowy = new List();

            nowy.Id = TerazId++;

            Console.WriteLine("Podaj nadawce listu");
            nowy.Nadawca = Console.ReadLine();

            Console.WriteLine("Podaj adres nadawcy");
            nowy.AdresNadawacy = Console.ReadLine();

            Console.WriteLine("Podaj odbiorce");
            nowy.Odbiorca = Console.ReadLine();

            Console.WriteLine("Podaj adres odbiorcy");
            nowy.AdresOdbiorcy = Console.ReadLine();

            Console.WriteLine("Jaki jest format listu?");
            nowy.Format = Console.ReadLine();

            Console.WriteLine("Czy ubezpieczyc list? [T/N]");

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowy.Ubezpieczenie = true;
            }
            else
            {
                nowy.Ubezpieczenie = false;
            }

            Console.WriteLine("Nadac priorytetem? [T/N]");
            info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowy.Priorytet = true;
            }
            else
            {
                nowy.Priorytet = false;
            }

            Console.WriteLine("A poleconym? [T/N]");
            info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowy.Polecony = true;
            }
            else
            {
                nowy.Polecony = false;
            }

            Przesylki.Add(nowy);
            Console.WriteLine("Dodana!");
            Console.ReadKey();

        }
        private void DodajPaczke()
        {
            Paczka nowa = new Paczka();

            nowa.Id = TerazId++;

            Console.WriteLine("Podaj nadawce paczki");
            nowa.Nadawca = Console.ReadLine();

            Console.WriteLine("Podaj adres nadawcy");
            nowa.AdresNadawacy = Console.ReadLine();

            Console.WriteLine("Podaj odbiorce");
            nowa.Odbiorca = Console.ReadLine();

            Console.WriteLine("Podaj adres odbiorcy");
            nowa.AdresOdbiorcy = Console.ReadLine();

            PowtorzLiczbe:
            try
            {
                Console.WriteLine("Podaj wymiary paczki (dl,szer,wys)");
                nowa.WymiarX = int.Parse(Console.ReadLine());
                nowa.WymiarY = int.Parse(Console.ReadLine());
                nowa.WymiarZ = int.Parse(Console.ReadLine());
                nowa.SprawdzenieObjetosci();

                Console.WriteLine("Podaj wage");
                nowa.Waga = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Musisz podac liczbe");
                goto PowtorzLiczbe;
            }

            Console.WriteLine("Czy ubezpieczyc paczke? [T/N]");

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowa.Ubezpieczenie = true;
            }
            else
            {
                nowa.Ubezpieczenie = false;
            }

            Console.WriteLine("Nadac priorytetem? [T/N]");
            info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowa.Priorytet = true;
            }
            else
            {
                nowa.Priorytet = false;
            }



            Przesylki.Add(nowa);
            Console.WriteLine("Dodana!");
            Console.ReadKey();
        }

        private void DodajSpecjalne()
        {
            Specjalne nowa = new Specjalne();

            nowa.Id = TerazId++;

            Console.WriteLine("Podaj nadawce paczki");
            nowa.Nadawca = Console.ReadLine();

            Console.WriteLine("Podaj adres nadawcy");
            nowa.AdresNadawacy = Console.ReadLine();

            Console.WriteLine("Podaj odbiorce");
            nowa.Odbiorca = Console.ReadLine();

            Console.WriteLine("Podaj adres odbiorcy");
            nowa.AdresOdbiorcy = Console.ReadLine();

            Console.WriteLine("Czy ubezpieczyc paczke? [T/N]");

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowa.Ubezpieczenie = true;
            }
            else
            {
                nowa.Ubezpieczenie = false;
            }

            Console.WriteLine("Nadac priorytetem? [T/N]");
            info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowa.Priorytet = true;
            }
            else
            {
                nowa.Priorytet = false;
            }

            Console.WriteLine("Jest to niebezpieczny towar? [T/N]");
            info = Console.ReadKey();
            if (info.KeyChar == 'T')
            {
                nowa.NiebezpiecznyTowar = true;
            }
            else
            {
                nowa.NiebezpiecznyTowar = false;
            }



            Przesylki.Add(nowa);
            Console.WriteLine("Dodana!");
            Console.ReadKey();
        }


        public void StanMagazynu()
        {
            foreach (var element in Przesylki)
            {
                element.Wypisanie();
            }

        }

        public void WyslijPaczke(Historia listaWyslanych)
        {
            Console.WriteLine("Ktora paczke wyslac? (podaj ID)");
            int ktora = int.Parse(Console.ReadLine());

            var doWyslania = Przesylki[ktora - 1];

            listaWyslanych.Wyslij(doWyslania);

            Przesylki.RemoveAt(ktora - 1);

            ZaktualizujId();
        }

        private void ZaktualizujId()
        {
            int noweId = 0;

            foreach (var element in Przesylki)
            {
                element.Id = ++noweId;
            }

            TerazId--;
        }

        public void WypiszPaczki()
        {
            foreach (var przesylka in Przesylki)
            {
                if (przesylka.Typ == "paczka")
                    przesylka.Wypisanie();
            }
        }

        public void WypiszListy()
        {
            foreach (var przesylka in Przesylki)
            {
                if (przesylka.Typ == "list")
                    przesylka.Wypisanie();
            }
        }

        public void WypiszSpecjalne()
        {
            foreach (var przesylka in Przesylki)
            {
                if (przesylka.Typ == "specjalne")
                    przesylka.Wypisanie();
            }
        }

        public void Szukaj()
        {
            Console.WriteLine("Podaj Tracking Number");
            int Szukany = int.Parse(Console.ReadLine());

            foreach (var pozycja in Przesylki)
            {
                if (pozycja.TrackingNumber == Szukany)
                    pozycja.Wypisanie();


            }
        }

        public bool SprawdzCzyIstniejeId(int number)
        {

            foreach (var paczka in Przesylki)
            {
                if (paczka.TrackingNumber == number)
                {
                    return true;
                }
            }

            return false;

        }


    }
}
