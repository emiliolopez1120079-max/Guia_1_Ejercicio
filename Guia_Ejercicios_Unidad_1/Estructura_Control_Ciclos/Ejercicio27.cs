using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//             Inversión de número - Invertir los dígitos de un número entero usando while, división entera y
//             módulo. Indicar además si el número es palíndromo (capicúa).
namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio27
    {

        public void InvertirNumero()
        {
            Console.WriteLine("Ingrese un número entero:");
            if(int.TryParse(Console.ReadLine(),out int n))
            {
                int aux=n;
                int inv=0;
                while(aux!=0)
                {
                    int d=aux%10;
                    inv=(inv*10)+d;
                    aux=aux/10;
                }
                Console.WriteLine($"\nNúmero original: {n}");
                Console.WriteLine($"Número invertido: {inv}");
                if(n==inv)
                {
                    Console.WriteLine("Es un número palíndromo");
                }
                else
                {
                    Console.WriteLine("no es un número palíndromo");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número entero.");
            }
        }
    }
}