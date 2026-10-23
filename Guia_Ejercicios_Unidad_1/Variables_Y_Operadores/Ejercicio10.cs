using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio10
    {
        public void Prestamos()
        {
            double interes, cuota;
            Console.Write($"Ingrese el monto del préstamo: ");
            double.TryParse(Console.ReadLine(), out double monto);
            Console.Write($"Ingrese la tasa de interés anual (%): ");
            double.TryParse(Console.ReadLine(), out double tasa);
            Console.Write($"Ingrese el plazo en meses: ");
            double.TryParse(Console.ReadLine(), out double meses);
            interes = monto*(tasa/100)*(meses/12);
            cuota = (monto + interes) / meses;
            Console.WriteLine($"Interés total: L {interes:F2}");
            Console.WriteLine($"Cuota mensual: L {cuota:F2}");
            Console.WriteLine($"Total a pagar: L {monto + interes:F2}");
        }
    }
}