using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio24
    {
        public void SumaParesImpares()
        {
            int n, sumaPares=0,sumaImpares=0,cantPares=0,cantImpares=0;
            Console.Write("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out n);
            for(int i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                    sumaPares+=i;
                    cantPares++;
                }
                else
                {
                    sumaImpares+=i;
                    cantImpares++;
                }
            }
            Console.WriteLine($"Suma de pares: {sumaPares}");
            Console.WriteLine($"Cantidad de pares: {cantPares}");
            Console.WriteLine($"Suma de impares: {sumaImpares}");
            Console.WriteLine($"Cantidad de impares: {cantImpares}");
        }
    }
}