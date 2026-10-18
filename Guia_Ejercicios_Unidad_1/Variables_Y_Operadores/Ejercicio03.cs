using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio03
    {
        public void Intercambio_Valores()
        {
            int A = 77;
            int B = 8;
            Console.WriteLine($"A: {A} y B:{B}");
             B = A+B;
             A = B-A;
             B= B-A;
            Console.WriteLine($"A: {A} y B:{B}");
        }
    }
}