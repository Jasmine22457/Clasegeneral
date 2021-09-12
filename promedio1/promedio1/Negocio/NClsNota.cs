using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using promedio1.Entidades;


namespace promedio1.Negocio
{
    class NClsNota
    {
        Promedio promedio = new Promedio();

        public string promedio1(Promedio final)
        {
            promedio.Promedio01 = (final.Laboratorio1 * 0.40) + (final.Parcial01* 0.60);
            promedio.Promedio02 = (final.Laboratorio02 * 0.40) + (final.Parcial02 * 0.60);
            promedio.Promedi03= (final.Laboratorio03 * 0.40) + (final.Parcial03 * 0.60);

            promedio.Nota_final = (promedio.Promedio01 + promedio.Promedio02 + promedio.Promedi03) / 3;


            Console.WriteLine("Su nota de primer periodo es: " + promedio.Promedio01);
            Console.WriteLine("Su nota de segundo periodo es: " + promedio.Promedio02);
            Console.WriteLine("Su nota de tercer periodo es: " + promedio.Promedi03);
            Console.WriteLine("Su nota final es: " + promedio.Nota_final);


            return "";




        }
    }
}
