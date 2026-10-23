using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio23
    {
        public void Tablas()
        {
            int num;
            Console.Write("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out num);
            for(int i=1;i<=12;i++)
            {
                Console.WriteLine($"{num} x {i,2} = \t{num*i,4}");
            }
        }
    }
}