using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio17
    {
        public void Descuentos()
        {
            Console.Write("Ingrese el monto de la compra en lempiras: ");
            double.TryParse(Console.ReadLine(), out double mOriginal);
            if (mOriginal<=0)
            {
                Console.WriteLine("Error: El monto ingresado debe ser mayor a 0.");
            }
            else
            {
                double descuento=0;
                if (mOriginal>=2500)
                {
                    descuento=0.15;
                }
                else if(mOriginal>=1000)
                {
                    descuento=0.10;
                }
                else if (mOriginal>=500)
                {
                    descuento=0.05;
                }
                else
                {
                    descuento=0.00;
                }
            double mDescuento = mOriginal*descuento;
            double Total = mOriginal-mDescuento;
            Console.WriteLine($"Precio original: L {mOriginal:N2}");
            Console.WriteLine($"Descuento ({descuento*100}%): L {descuento:N2}");
            Console.WriteLine($"Precio final:    L {Total:N2}");
        }
        }
    }
}