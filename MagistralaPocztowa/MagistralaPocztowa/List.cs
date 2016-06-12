using System;

namespace MagistralaPocztowa
{
    class List : Przesylka
    {
        public bool Polecony { get; set; }
        public string Format { get; set; }

        public List()
        {

            Random rand1 = new Random();
            TrackingNumber = rand1.Next(501, 999);
            Typ = "list";
        }

        public override void Wypisanie()
        {

            Console.WriteLine("\n" + Id + ". Nadawca: ");
            Console.WriteLine(Nadawca);
            Console.WriteLine(AdresNadawacy);
            Console.WriteLine("Odbiorca: " + Odbiorca);
            Console.WriteLine(AdresOdbiorcy);
            Console.WriteLine("Typ paczki: list");
            Console.WriteLine("Tracking number: " + TrackingNumber);

            if (Ubezpieczenie)
                Console.WriteLine("Paczka ubezpieczona");

            if (Priorytet)
                Console.WriteLine("Paczka priorytetowa");
        }
    }
}
