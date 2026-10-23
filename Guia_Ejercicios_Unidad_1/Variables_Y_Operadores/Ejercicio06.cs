using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio06
    {
        public void SumaDigitos()
        {
         Console.WriteLine($"Introduzca un muero de tres");
         int.TryParse(Console.ReadLine(), out int numero);
         if(numero<100||numero>999)
            {
                Console.WriteLine($"numero invalido");
            }
         int centena = numero/100;
         int decenas = (numero/10)%10;
         int unidades = numero%10;
         int suma = centena+decenas+unidades;
         Console.WriteLine($"La suma es de {suma}");
        }
    }
}