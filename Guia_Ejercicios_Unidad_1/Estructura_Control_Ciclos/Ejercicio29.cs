using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio29
    {
        public void Fiboncci()
        {
            int a = 0;
            int b = 1;
            int c;
            double suma = 0;
            double promedio; 
            Console.WriteLine("Ingrese la cantidad de numeros de la serie de Fibonacci desea generar");
            if(int.TryParse(Console.ReadLine(), out int n)&&n>=0)
            {
                if(n==0)
                {
                    Console.WriteLine("No se genero ningun numero");
                }
                else
                {
                    for(int i=0;i<n;i++)
                    {
                        if(i==0)
                        {
                            c=0;
                        }
                        else if(i==1)
                        {
                            c=1;
                        }
                        else
                        {
                            c=b+a;
                            a=b;
                            b=c;
                        }
                        Console.WriteLine(c);
                        suma+=c;
                    }
                    promedio=suma/n;
                    Console.WriteLine($"Suma total: {suma}");
                    Console.WriteLine($"Promedio: {promedio:F2}");
                }
            }
        }
    }
}