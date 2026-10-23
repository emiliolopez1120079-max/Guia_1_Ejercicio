using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Listas
{
    public class Ejercicio49
    {
        public void SepararParesImpares()
        {
            //aqui hacemos el codigo pa ver si se puede separar los pares e impares bien :v
            List<int> numeros=new List<int>();
            List<int> pares=new List<int>();
            List<int> impares=new List<int>();
            int num=0;
            //llenamos la lista principal pidiendo exactamente 15 numeros enteros
            for(int i=0;i<15;i++)
            {
                Console.WriteLine($"Ingrese el numero {i+1}");
                while(!int.TryParse(Console.ReadLine(),out num))
                {
                    Console.WriteLine("Tiene que introducir un numero valido");
                }
                numeros.Add(num); //agregamos el numero ingresado a la lista
            }
            //recorremos la lista principal para clasificar sus valores
            foreach(int item in numeros)
            {
                if(item%2==0)
                {
                    pares.Add(item); //si es divisible por 2 lo mandamos a pares
                }
                else
                {
                    impares.Add(item); //si no, lo mandamos a impares
                }
            }
            //ordenamos ambas listas usando Sort de forma ascendente
            pares.Sort();
            impares.Sort();
            //mostramos los resultados en consola sin punto al final
            Console.WriteLine("\n  Numeros Pares Ordenados");
            for(int i=0;i<pares.Count;i++) //recorremos la lista de pares para mostrarlos
            {
                Console.WriteLine($"Par {i+1}={pares[i]}");
            }

            Console.WriteLine("\n   Numeros Impares Ordenados");
            for(int i=0;i<impares.Count;i++) //recorremos la lista de impares para mostrarlos
            {
                Console.WriteLine($"Impar {i+1}={impares[i]}");
            }
        }
    }
}