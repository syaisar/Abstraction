using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Kapal_Tempur : IKendaraan
    {
        public void Senjata()
        {
            Console.WriteLine("Kapal_Tempur Menembak dengan Rudal");
            Console.WriteLine("Dengan cara bantuan Peluru");
        }
    }

}
