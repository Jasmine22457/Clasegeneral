using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda1.Entidades;
using tienda1.Negocio;
namespace tienda1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido querido usuario");
            Console.WriteLine("Inserta el valor de tu compra:");
            double monto_de_compra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el ID del día que realizas tu compra:");
            Console.WriteLine("1 : Lunes - 2: Martes – 3: Miércoles – 4: Jueves – 5: Viernes – 6: Sábado – 7: Domingo");
            int dia_de_la_semana = Convert.ToInt32(Console.ReadLine());

            Tienda1 tienda1 = new Tienda1(monto_de_compra, dia_de_la_semana);
            NClstienda_pepe tienda = new NClstienda_pepe();
            Console.WriteLine(tienda.Tiendita(tienda1));
            Console.ReadLine();
        }
    }
}
