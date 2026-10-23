using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio28
    {
        public void DecimalABinario()
        {
            Console.WriteLine("Ingrese un número entero positivo");
            if(int.TryParse(Console.ReadLine(),out int n)&&n>=0)
            {
                if(n==0)
                {
                    Console.WriteLine("Binario: 0");
                    return;
                }
                int aux=n;
                string bin="";
                while(aux>0)
                {
                    int r=aux%2;
                    bin=r+bin;
                    aux=aux/2;
                }
                Console.WriteLine($"Número original: {n}");
                Console.WriteLine($"Binario: {bin}");
            }
            else
            {
                Console.WriteLine("Tiene que ingresar un número entero positivo.}");
            }
        }
    }
}