using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagistralaPocztowa
{
    public class Historia:IWrite
    {
        public List<Przesylka> Wyslane;
        private int terazId { get; set; } = 0;


        public Historia()
        {
            Wyslane = new List<Przesylka>();
        }

        public void Wyslij(Przesylka nowa)
        {
            Wyslane.Add(nowa);
            Wyslane[terazId].Id = terazId + 1;
        }

        public void Wypisz()
        {
            foreach (var pozycja in Wyslane)
            {
                pozycja.Wypisanie();
            }
        }


    }
}
