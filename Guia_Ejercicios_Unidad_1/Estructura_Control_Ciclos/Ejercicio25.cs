using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio25
    {
        public void Promedio_Centinela()
        {
            int suma=0, cant=0, max=int.MinValue, min=int.MaxValue;
            double promedio;
            Console.Write("Ingrese un numero -1 para terminar");
            int.TryParse(Console.ReadLine(), out int num);
            while(num!=-1)
            {
                suma+=num;
                cant++;
                if(num>max)
                {
                    max=num;
                }
                if(num<min)
                {
                    min=num;
                }   
            Console.Write("Ingrese un numero -1 para terminar");
            int.TryParse(Console.ReadLine(), out num);
        }
        if(cant>0)
        {
            promedio=(double)suma/cant;
            Console.WriteLine("Promedio: "+promedio);
            Console.WriteLine("Valor maximo: "+max);
            Console.WriteLine("Valor minimo: "+min);
        }
        else
        {
        Console.WriteLine("No se ingresaron numeros");
        }
        }
    }
}