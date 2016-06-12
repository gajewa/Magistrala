using System;

namespace MagistralaPocztowa
{
    class Program
    {
        static void Main()
        {
            Magazyn listaPrzesylek = new Magazyn();
            Historia listaWyslanych = new Historia();
            

            int option;

            do
            {
                Console.Clear();
                WyswietlMenu();

                ConsoleKeyInfo info = Console.ReadKey();

                option = (int)Char.GetNumericValue(info.KeyChar);

                Console.Clear();


                switch (option)
                {
                    case 1:
                        listaPrzesylek.DodajPozycje();
                        break;
                    case 2:
                        listaPrzesylek.StanMagazynu();
                        Console.ReadKey();
                        break;
                    case 3:
                        listaPrzesylek.WyslijPaczke(listaWyslanych);
                        break;
                    case 4:
                        Console.WriteLine("Historia wyslanych przesylek:");
                        listaWyslanych.Wypisz();
                        Console.ReadKey();
                        break;
                    case 5:
                        listaPrzesylek.WypiszListy();
                        Console.ReadKey();
                        break;
                    case 6:
                        listaPrzesylek.WypiszPaczki();
                        Console.ReadKey();
                        break;
                    case 7:
                        listaPrzesylek.WypiszSpecjalne();
                        Console.ReadKey();
                        break;
                    case 8: 
                        listaPrzesylek.Szukaj();
                        Console.ReadKey();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Zla opcja");
                        break;
                }
            } while (option != 9);

           


        }

        private static void WyswietlMenu()
        {
        
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine();
            Console.WriteLine("    Wybierz opcje:");
            Console.WriteLine("       1. Dodaj paczke");
            Console.WriteLine("       2. Wyswietl zawartosc magazynu");
            Console.WriteLine("       3. Wyslij paczke do dobiorcy");
            Console.WriteLine("       4. Historia wyslanych przesylek");
            Console.WriteLine("       5. Wypisz listy");
            Console.WriteLine("       6. Wypisz paczki");
            Console.WriteLine("       7. Wypisz specjalne");
            Console.WriteLine("       8. Szukaj po tracking numberze");
            Console.WriteLine("       9. Wyjdz z programu");
            Console.WriteLine();
            Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            
        }
    }
}
