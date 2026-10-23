using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio30
    {
        public void Factorial()
        {
            Console.WriteLine("Ingrese el numer0 n");
            if(int.TryParse(Console.ReadLine(),out int n)&&n>=0)
            {
                Console.WriteLine("Ingrese el numero de r");
                if(int.TryParse(Console.ReadLine(),out int r)&&r>=0&&r<=n)
                {
                    int factN=1;
                    for(int i=1;i<=n;i++)
                    {
                        factN*=i;
                    }
                    int factR=1;
                    for(int i=1;i<=r;i++)
                    {
                        factR*=i;
                    }
                    int factNR=1;
                    for(int i=1;i<=n-r;i++)
                    {
                        factNR*=i;
                    }
                    int combinacion=factN/(factR*factNR);
                    Console.WriteLine($"ell factorial de {n} es: {factN}");
                    Console.WriteLine($"Las combinaciones C({n},{r}) son: {combinacion}");
                }
                else
                {
                    Console.WriteLine("E r debe ser un entero positivo y menor o igual a n para restarse :v");
                }
            }
            else
            {
                Console.WriteLine("N DEbe ser un entero positivo");
            }
        }

    }
}