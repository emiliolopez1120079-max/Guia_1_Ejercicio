using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio31
    {
        public void MCD_mmcm()
        {
            Console.WriteLine("Ingrese el primer número");
            int a=0;
            if(int.TryParse(Console.ReadLine(),out a)&&a>0)
            {
                Console.WriteLine("Ingrese el segundo número");
                if(int.TryParse(Console.ReadLine(),out int b)&&b>0)
                {
                    int x=a;
                    int y=b;
                    while(y!=0)
                    {
                        int t=y;
                        y=x%y;
                        x=t;
                    }
                    int mcd=x;
                    int mcm=(a*b)/mcd;
                    Console.WriteLine($"El MCD es: {mcd}");
                    Console.WriteLine($"El MCM es: {mcm}");
                }
                else
                {
                    Console.WriteLine("El numero esra mal");
                }
            }
            else
            {
                Console.WriteLine("El numero esra mal");
            }
        }
    }
}