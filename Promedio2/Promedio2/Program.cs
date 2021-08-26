using Promedio2.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio2
{
    class Program
    {
        static void Main(string[] args)
        {

            NClsNotas1 notas = new NClsNotas1(9, 10, 8, 9, 8, 9);

            Console.WriteLine(notas.ToString());
            Console.ReadLine();


        }

    }
}
