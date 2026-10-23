using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio44
    {
        public void Histograma()
        {
            //aqui hacemos el codigo pa ver si se puede armar el histograma bien :v
            Console.WriteLine("Ingrese la cantidad de calificaciones n");
            int.TryParse(Console.ReadLine(),out int n);
            if(n<=0)
            {
                Console.WriteLine("Cantidad no valida");
            }
            else
            {
                int[] calificaciones=new int[n];
                int r0_59=0;
                int r60_69=0;
                int r70_79=0;
                int r80_89=0;
                int r90_100=0;
                for(int i=0;i<calificaciones.Length;i++) //llenamos el arreglo pidiendo cada calificacion del 0 al 100
                {
                    Console.WriteLine($"Ingrese la calificacion {i+1}");
                    while(!int.TryParse(Console.ReadLine(),out calificaciones[i])||calificaciones[i]<0||calificaciones[i]>100)
                    {
                        Console.WriteLine("Tiene que introducir un numero valido entre 0 y 100");
                    }
                }
                for(int i=0;i<calificaciones.Length;i++) //recorremos para contar cuantas caen en cada rango
                {
                    int nota=calificaciones[i];
                    if(nota<=59)
                    {
                        r0_59++;
                    }
                    else if(nota>=60&&nota<=69)
                    {
                        r60_69++;
                    }
                    else if(nota>=70&&nota<=79)
                    {
                        r70_79++;
                    }
                    else if(nota>=80&&nota<=89)
                    {
                        r80_89++;
                    }
                    else
                    {
                        r90_100++;
                    }
                }
                Console.WriteLine("Histograma de Calificaciones");
                Console.Write("00-59:\t");
                for(int i=0;i<r0_59;i++) //dibujamos los asteriscos pa el primer rango
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r0_59})");
                Console.Write("60-69:\t");
                for(int i=0;i<r60_69;i++) //dibujamos los asteriscos pa el segundo rango
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r60_69})");
                Console.Write("70-79:\t");
                for(int i=0;i<r70_79;i++) //dibujamos los asteriscos pa el tercer rango
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r70_79})");
                Console.Write("80-89:\t");
                for(int i=0;i<r80_89;i++) //dibujamos los asteriscos pa el cuarto rango
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r80_89})");      
                Console.Write("90-100:\t");
                for(int i=0;i<r90_100;i++) //dibujamos los asteriscos pa el quinto rango
                {
                    Console.Write("*");
                }
                Console.WriteLine($" ({r90_100})");
            }
        }
    }
}