using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio32
    {
        public void Primos()
        {
            int inicio, fin;
            int cantidadPrimos=0;
            Console.Write($"Ingrese el inicio del rango: ");
            int.TryParse(Console.ReadLine(), out inicio);
            Console.Write($"Ingrese el final del rango: ");
            int.TryParse(Console.ReadLine(), out fin);
            for(int numero=inicio;numero<=fin;numero++)
            {
                int divisores=0;
                // Comprobar cuántos divisores tiene el número
                for(int i=1;i<=numero;i++)
                {
                    if(numero%i==0)
                    {
                        divisores++;
                    }
                }
                // Si tiene exactamente dos divisores, es primo
                if(divisores==2)
                {
                    Console.Write($"{numero} ");
                    cantidadPrimos++;
                }
            }
            Console.WriteLine($"\nCantidad de números primos: {cantidadPrimos}");
        }
    }
}