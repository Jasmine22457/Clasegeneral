using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Entidades;

namespace Cajero.Negocio
{
    class NClsDinero
    {
        public string Dinero(cajero1 cajero1 )
        {
            int dato = 1;
            while (dato == 1)
            {

                Console.WriteLine("Por favor ingrese la cantidad a retirar:");
                cajero1.Cantidad = Convert.ToInt32(Console.ReadLine());


                if (cajero1.Cantidad % 5 == 0)
                {

                    Console.WriteLine("Transaccion exitosa");
                  

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 1)
                    {
                        dato = dato + 1 ;

                    }
                 
                }
                else

                {
                    dato = 2;
                    return "Error, no puedes sacar tu dinero";
                    
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    
               
                     
           


                }
               
               

            }
            return"";
            }

 
        }
 }
