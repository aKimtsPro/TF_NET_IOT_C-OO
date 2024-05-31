using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Utils
{
    internal sealed class Parking
    {

        private static Parking _instance;

        public static Parking Instance
        {
            get { return _instance == null ? _instance = new Parking() : _instance  ; }
        }


        private Parking() {
            Console.WriteLine("Parking instancié");
        }
    }
}
