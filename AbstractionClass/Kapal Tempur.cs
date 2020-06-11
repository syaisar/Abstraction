using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class Kapal_Tempur : Kendaraan
    {
        public override void Senjata()
        {
            Console.WriteLine("Kapal_Tempur Menembak dengan Rudal");
            Console.WriteLine("Dengan cara bantuan Peluru");
        }
    }
}
