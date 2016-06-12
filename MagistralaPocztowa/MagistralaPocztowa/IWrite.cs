using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagistralaPocztowa
{
    interface IWrite
    {
        void Wypisz();
        void Wyslij(Przesylka nowa);
    }
}
