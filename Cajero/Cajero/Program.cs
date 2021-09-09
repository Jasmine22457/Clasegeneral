using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Entidades;
using Cajero.Negocio;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            cajero1 cajero1 = new cajero1();
            NClsDinero cantidad = new NClsDinero();
            Console.WriteLine(cantidad.Dinero(cajero1));
            Console.ReadLine();

        }
    }
}
