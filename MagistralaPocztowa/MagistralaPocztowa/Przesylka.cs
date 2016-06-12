using System;

namespace MagistralaPocztowa
{
    public abstract class Przesylka
    {
        public bool Ubezpieczenie { get; set; }
        public bool Priorytet { get; set; }
        public string Nadawca { get; set; }
        public string AdresNadawacy{ get; set; }
        public string Odbiorca { get; set; }
        public string AdresOdbiorcy { get; set; }
        public int Id { get; set; }
        public string Typ { get; set; }
        public int TrackingNumber { get; set; }


        public virtual void Wypisanie()
        {
            Console.WriteLine("\n" + Id + ". Nadawca: ");
            Console.WriteLine(Nadawca);
            Console.WriteLine(AdresNadawacy);
            Console.WriteLine("Odbiorca: " + Odbiorca);
            Console.WriteLine(AdresOdbiorcy);
            Console.WriteLine("Typ paczki: " + Typ);

            if (Ubezpieczenie)
                Console.WriteLine("Paczka ubezpieczona");

            if (Priorytet)
                Console.WriteLine("Paczka priorytetowa");
        }
    }
}
