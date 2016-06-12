using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagistralaPocztowa
{
    class Specjalne : Przesylka
    {
        public bool NiebezpiecznyTowar { get; set; }

        public Specjalne()
        {

            Random rand1 = new Random();
            TrackingNumber = rand1.Next(1000, 9999);

            Typ = "specjalne";
        }


        public override void Wypisanie()
        {

            Console.WriteLine("\n" + Id + ". Nadawca: ");
            Console.WriteLine(Nadawca);
            Console.WriteLine(AdresNadawacy);
            Console.WriteLine("Odbiorca: " + Odbiorca);
            Console.WriteLine(AdresOdbiorcy);
            Console.WriteLine("Typ paczki: przesylka specjalna");

            if (Ubezpieczenie)
                Console.WriteLine("Paczka ubezpieczona");

            if (Priorytet)
                Console.WriteLine("Paczka priorytetowa");

            Console.WriteLine("Tracking number:" + TrackingNumber);
        }
    }
}
