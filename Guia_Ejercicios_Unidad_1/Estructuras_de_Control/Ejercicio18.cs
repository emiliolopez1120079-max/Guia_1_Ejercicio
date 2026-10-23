using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio18
    {
        public void Tarifa()
        {
            int i=1;
            int monto=0;
            Console.WriteLine($"Introduzca las hioras de estyacionamiento");
            int.TryParse(Console.ReadLine(), out int horas);
            if(horas<0)
            {
                Console.WriteLine($"Error al ontrdocir las horas");
            }
            else if(horas==0)
            {
                Console.WriteLine($"El costo es de L 0"); 
            }
            else
            {
                while(i<=horas||monto<100)
                {
                    if(i==1)
                    {
                        monto=20;
                    }
                    else
                    {
                     monto+=10;   
                    }
                    i++;
                }
                Console.WriteLine($"EL monto es de L {monto}");
            }
        }
    }
}