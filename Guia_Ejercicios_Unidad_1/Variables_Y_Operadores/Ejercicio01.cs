using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio01
    {
        public void Conversor_Moneda()
        {
         Console.WriteLine($"Ingrese una cantidad en Lempiras y se convertira a Dolares y a Euros");
         float.TryParse(Console.ReadLine(), out float cantidad);

         double euros = cantidad*0.033;
         double dolares = cantidad*0.037;
         Console.WriteLine($"La conversacion de lempiras a uros es de:{euros:F2} y a dolares {dolares:F2}");
        }
    }
}