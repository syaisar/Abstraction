using Abstraction.AbstractionClass;
using Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;
//using Abstraction.Interface;


namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Kendaraan kendaraan;
            kendaraan = new PesawatTempur ();
            kendaraan.Senjata();

            Console.WriteLine();
            kendaraan = new Kapal_Tempur ();
            kendaraan.Senjata();

            Console.WriteLine();
            kendaraan = new Tank ();
            kendaraan.Senjata();


            /*Kendaraan kendaraan;
            kendaraan = new Pesawat_Tempur();
            kendaraan.Senjata();

            Console.WriteLine();
            kendaraan = new Kapal_Tempur();
            kendaraan.Senjata();

            Console.WriteLine();
            kendaraan = new Tank();
            kendaraan.Senjata()*/

            Console.ReadKey();
        }
    }
}