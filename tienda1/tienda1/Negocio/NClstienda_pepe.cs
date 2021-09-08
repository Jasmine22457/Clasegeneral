using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda1.Entidades;

namespace tienda1.Negocio
{
    class NClstienda_pepe
    {
     

        public string Tiendita(Tienda1 tienda1)
        {
             
            if (tienda1.Dia_de_la_semana == 2 || tienda1.Dia_de_la_semana == 4)
            {
                tienda1.Descuento = (0.15 * tienda1.Monto_de_compra);
                tienda1.Total = (tienda1.Monto_de_compra - tienda1.Descuento);

                return "Se le aplico el 15% de descuento a su compra , su monto a pagar sera de : " +tienda1.Total ;
            }

            else if(tienda1.Dia_de_la_semana == 1|| tienda1.Dia_de_la_semana == 3 || tienda1.Dia_de_la_semana == 5 || tienda1.Dia_de_la_semana == 6 || tienda1.Dia_de_la_semana == 7)

            {
                tienda1.Total = tienda1.Monto_de_compra;

                return "El descuento no esta disponible , su monto a pagar sera de : " + tienda1.Total;

            }
            else { return " A ingresado un dia no disponible";}
















         }

        
    }
}
