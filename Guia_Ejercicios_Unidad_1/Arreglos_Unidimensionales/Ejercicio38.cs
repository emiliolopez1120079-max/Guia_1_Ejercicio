using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejericicio38
    {
        public void LIstaNombres()
        {
            string maslargo;
            // Solicitar la cantidad de nombres
            Console.WriteLine("Ingrese la cantidad de nombre que quiere ingresar");
            string[] nombres = new string[5];
            // Recorrer para llenar el arreglo de nombres
            for(int i=0;i<nombres.Length;i++)
            {
                Console.WriteLine($"Posiscion{i+1}");
                nombres[i] = Console.ReadLine();   
                // Validar que el nombre no sea nulo
                while(nombres[i] is null)
                {
                    Console.WriteLine("Ingrese un nombre valido");
                    nombres[i] = Console.ReadLine();
                }
            }
            maslargo= nombres[0];
            int j=0;
            // Mostrar los nombres en orden inverso
            for(int i=nombres.Length-1;i>=0;i--)
            {
                j++;          
                Console.WriteLine($"Nombre{j}: {nombres[i]}");
            }
            // Encontrar el nombre mas largo usando foreach
            foreach(string nombre in nombres)
            {
                if(nombre.Length>maslargo.Length)
                {
                    maslargo=nombre;
                }
            }
            // Buscar un nombre especifico dentro del arreglo
            Console.WriteLine("Ingrese el numero que quiere buscar");
            string buscar=Console.ReadLine();
            bool encontrado=false;
            for(int i=0;i<nombres.Length;i++)
            {
                if(nombres[i]==buscar)
                {
                  encontrado=true;   
                }
            }
            // Mostrar resultados finales
            Console.WriteLine($"El nomre mas largo es: {maslargo}");
            if(encontrado)
            Console.WriteLine($"Se encontro el nombre ingresado");
            else
            Console.WriteLine($"No se encontro el nombre ingresado");

        }
    }
}