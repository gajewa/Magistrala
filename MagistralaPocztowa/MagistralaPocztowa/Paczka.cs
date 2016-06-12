using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagistralaPocztowa
{
    public class Paczka : Przesylka
    {
        enum Objetosc
        {
            duza,
            standardowa,
            mala
        }

        public int Waga { get; set; }
        public int WymiarX { get; set; }
        public int WymiarY { get; set; }
        public int WymiarZ { get; set; }
        private Objetosc jakaObjetosc = Objetosc.mala;

        public Paczka()
        {

            Random rand1 = new Random();
            TrackingNumber = rand1.Next(0, 500);

            Typ = "paczka";
        }

      

        public void SprawdzenieObjetosci()
        {
            int value = WymiarX * WymiarY * WymiarZ / 1000;
            if (value < 3)
            { jakaObjetosc = Objetosc.mala; }
            else if (value >= 3 && value <= 5)
            { jakaObjetosc = Objetosc.standardowa; }
            else
            { jakaObjetosc = Objetosc.duza; }
        }

        private void WypiszObjetosc()
        {
            switch (jakaObjetosc)
            {
                case Objetosc.duza:
                    Console.WriteLine("Duza objetosc - moze wystapic doplata!!");
                    break;
                case Objetosc.mala:
                    Console.WriteLine("Mala objetosc, prosimy dobrze zapakowac");
                    break;
                case Objetosc.standardowa:
                    Console.WriteLine("Objetosc standardowa");
                    break;
                default: break;
            }
        }

        public override void Wypisanie()
        {

            Console.WriteLine("\n" + Id + ". Nadawca: ");
            Console.WriteLine(Nadawca);
            Console.WriteLine(AdresNadawacy);
            Console.WriteLine("Odbiorca: " + Odbiorca);
            Console.WriteLine(AdresOdbiorcy);
            Console.WriteLine("Typ paczki:  paczka");
            Console.WriteLine("Waga: " + Waga + " kg");
            Console.WriteLine("Wymiary paczki: " + WymiarX + "cm  x " + WymiarY + "cm x " + WymiarZ + "cm");
            Console.WriteLine("Objetosc paczki:" + WymiarX * WymiarY * WymiarZ / 1000 + " l ");
            WypiszObjetosc();
            Console.WriteLine("Tracking number: " + TrackingNumber);

            if (Ubezpieczenie)
                Console.WriteLine("Paczka ubezpieczona");

            if (Priorytet)
                Console.WriteLine("Paczka priorytetowa");


        }
    }
}
