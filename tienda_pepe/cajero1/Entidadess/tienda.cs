using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero1.Entidades
{
    class tienda
    {

        private Double monto_de_compra;
        private int dia_de_la_semana;
        private Double descuento;
        private Double pago_total;



        public double Monto_de_compra { get => monto_de_compra; set => monto_de_compra = value; }
        public int Dia_de_la_semana { get => dia_de_la_semana; set => dia_de_la_semana = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Pago_total { get => pago_total; set => pago_total = value; }

        public tienda(double monto_de_compra, int dia_de_la_semana)
        {
            this.monto_de_compra = monto_de_compra;
            this.dia_de_la_semana = dia_de_la_semana;
           
            

        }

    }
}
