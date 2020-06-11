using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Tank : IKendaraan
    {
        public void Senjata()
        {
            Console.WriteLine("Tank Menembak dengan Rudal");
            Console.WriteLine("Dengan cara bantuan peluru");
        }
    }

}
