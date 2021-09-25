using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_promedios.Entidades;
namespace practica_promedios.Negocio
{
    class NClsPropiedades
    {
     
        public string promedioos(notas notass)
        {
            notass.Promedio01 = (notass.Laboratorio1 * 0.40) + (notass.Parcial01 * 0.60);
            notass.Promedio02 = (notass.Laboratorio02 * 0.40) + (notass.Parcial02 * 0.60);
            notass.Promedi03 = (notass.Laboratorio03 * 0.40) + (notass.Parcial03 * 0.60);

            notass.Nota_final = (notass.Promedio01 + notass.Promedio02 + notass.Parcial03) / 3;

            
             

            return "su nota de periodo 1 es  "+ notass.Promedio01 + "\n su nota de  periodo 2 es " + notass.Promedio02 + "\n su nota de  periodo 3 es "+ notass.Promedi03 + "\n su promedio final es: " + notass.Nota_final;
        }

    }
}
