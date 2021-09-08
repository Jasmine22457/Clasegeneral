using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda1.Entidades
{
    class Tienda1
    {

        private Double monto_de_compra;
        private int dia_de_la_semana;
        private Double descuento;
        private Double total;

       

        public double Monto_de_compra { get => monto_de_compra; set => monto_de_compra = value; }
        public int Dia_de_la_semana { get => dia_de_la_semana; set => dia_de_la_semana = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Total { get => total; set => total = value; }
        public Tienda1(double monto_de_compra, int dia_de_la_semana)
        {
            this.monto_de_compra = monto_de_compra;
            this.dia_de_la_semana = dia_de_la_semana;
        }
    }
}
