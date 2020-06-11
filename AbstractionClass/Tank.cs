using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class Tank : Kendaraan
    {
        public override void Senjata()
        {
            Console.WriteLine("Tank Menembak dengan Rudal");
            Console.WriteLine("Dengan cara bantuan peluru");
        }
    }
}
