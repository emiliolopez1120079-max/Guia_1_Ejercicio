using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio37
    {
       public void List_numeros()
        {
            int suma =0;
            int mayor=0;
            int menor=0;
            int suma2=0;
            int mayor2=0;
            int menor2=0;
            //cantidad de numeros
            Console.WriteLine($"Ingrese una cantidad de numeros n");
            int.TryParse(Console.ReadLine(), out int a);
            if(a<=0)
            {
                //Valid numero mayor a cero
                Console.WriteLine($"Ingrese otro numero");
            }
            else
            {
               int[] lista = new int[a]; 
               //Llenar arreglo con for
               for(int i=0;i<lista.Length;i++)
                {
                    while(!int.TryParse(Console.ReadLine(), out  lista[i]))
                    {
                        Console.WriteLine("Tiene que introducir un numero");
                    }
                }
                //Inicializar variables de comparacion
                mayor= lista[0];
                menor=lista[0];
                mayor2= lista[0];
                menor2=lista[0];
                //Recorrer con for para operaciones
                for(int i=0;i<lista.Length;i++)
                {
                    suma += lista[i];
                    if(mayor<lista[i])
                    {
                        mayor=lista[i];
                    }
                    if(menor>lista[i])
                    {
                        menor=lista[i];
                    }
                }
                //Mostrar resultados del ciclo for
                Console.WriteLine($"Suma= {suma} Mayor={mayor} Menor{menor} Promedio={suma/lista.Length}");
                //Recorrer con foreach para operaciones
                foreach(int item in lista)
                {
                   suma2 += item;
                    if(mayor2<item)
                    {
                        mayor2=item;
                    }
                    if(menor2>item)
                    {
                        menor2=item;
                    }   
                }
                //Mostrar resultados del ciclo foreach
                 Console.WriteLine($"Suma= {suma2} Mayor={mayor2} Menor{menor2} Promedio={suma2/lista.Length}");
            }
        }
    }
}