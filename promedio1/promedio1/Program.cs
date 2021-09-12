using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using promedio1.Entidades;
using promedio1.Negocio;

namespace promedio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Promedio pro = new Promedio();
            NClsNota nClsNota = new NClsNota();

            pro.Laboratorio1 = 9;
            pro.Parcial01 = 8;
            pro.Laboratorio02 = 9;
            pro.Parcial02 = 8;
            pro.Laboratorio03 = 9;
            pro.Parcial03 = 8;

            Promedio final = new Promedio(pro.Laboratorio1, pro.Parcial01, pro.Laboratorio02, pro.Parcial02, pro.Laboratorio03, pro.Parcial03);

            Console.WriteLine(nClsNota.promedio1(final));

            Console.ReadLine();


        }
    }
}
