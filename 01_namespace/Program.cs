using System;
using I = Iot;
using T = Technofutur;

namespace _01_namespace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");

            var course = new I.MaClasse();
            course.Hello();

            var centre = new T.MaClasse();
            centre.Hello();
        }
    }
}

namespace Iot
{
    internal class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Hello les IoT's");
        }
    }
}

namespace Technofutur
{
    internal class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Bienvenue à Technofutur");
        }
    }
}