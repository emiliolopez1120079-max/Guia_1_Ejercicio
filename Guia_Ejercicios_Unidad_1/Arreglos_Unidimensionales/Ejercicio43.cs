using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio43
    {
        public void RotacionInversion()
        {
            //aqui hacemos el codigo pa ver si se puede rotar bien :v
            Console.WriteLine("Ingrese la cantidad de elementos n");
            int.TryParse(Console.ReadLine(),out int n);
            if(n<=0)
            {
                Console.WriteLine("Cantidad no valida");
            }
            else
            {
                int[] arreglo=new int[n];

                for(int i=0;i<arreglo.Length;i++) //llenamos el arreglo con los valores que meta el usuario
                {
                    Console.WriteLine($"Ingrese el elemento {i+1}");
                    while(!int.TryParse(Console.ReadLine(),out arreglo[i]))
                    {
                        Console.WriteLine("Tiene que introducir un numero valido");
                    }
                }
                int op=0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Elija la opcion que quiera");
                    Console.WriteLine("1. Rotar K posiciones a la izquierda");
                    Console.WriteLine("2. Rotar K posiciones a la derecha");
                    Console.WriteLine("3. Invertir arreglo");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opcion: ");
                    if(int.TryParse(Console.ReadLine(),out op))
                    {
                        if(op==1||op==2)
                        {
                            Console.Write("Ingrese las posiciones K a rotar: ");
                            int k;
                            while(!int.TryParse(Console.ReadLine(),out k)||k<0)
                            {
                                Console.Write("Tiene que introducir un numero valido (0 o mayor): ");
                            }
                            k=k%n; //ajustamos k por si es mayor que el tamaño del arreglo
                            if(op==1)
                            {
                                for(int paso=0;paso<k;paso++) //rotamos a la izquierda tantas veces como indique k
                                {
                                    int aux=arreglo[0];
                                    for(int i=0;i<arreglo.Length-1;i++) //corremos todos los elementos hacia la izquierda
                                    {
                                        arreglo[i]=arreglo[i+1];
                                    }
                                    arreglo[arreglo.Length-1]=aux;
                                }
                                Console.WriteLine("Arreglo rotado a la izquierda");
                            }
                            else if(op==2)
                            {
                                for(int paso=0;paso<k;paso++) //rotamos a la derecha tantas veces como indique k
                                {
                                    int aux=arreglo[arreglo.Length-1];
                                    for(int i=arreglo.Length-1;i>0;i--) //corremos todos los elementos hacia la derecha
                                    {
                                        arreglo[i]=arreglo[i-1];
                                    }
                                    arreglo[0]=aux;
                                }
                                Console.WriteLine("Arreglo rotado a la derecha");
                            }
                            Console.WriteLine("Foama actual del arreglo:");
                            for(int i=0;i<arreglo.Length;i++) //mostramos como quedo el arreglo despues de la rotacion
                            {
                                Console.Write($"{arreglo[i]} ");
                            }
                            Console.WriteLine();
                        }
                        else if(op==3)
                        {
                            for(int i=0;i<arreglo.Length/2;i++) //invertimos intercambiando los extremos hacia el centro
                            {
                                int temp=arreglo[i];
                                arreglo[i]=arreglo[arreglo.Length-1-i];
                                arreglo[arreglo.Length-1-i]=temp;
                            }
                            Console.WriteLine("Arreglo invertido correctamente:");
                            for(int i=0;i<arreglo.Length;i++) //mostramos el arreglo ya invertido
                            {
                                Console.Write($"{arreglo[i]} ");
                            }
                            Console.WriteLine();
                        }
                        else if(op==4)
                        {
                            Console.WriteLine("Saliendo");//salimos del sistema sin punto al final
                        }
                        else
                        {
                            Console.WriteLine("opcion fuera de rango");
                        }
                    }
                    else
                    {
                        Console.WriteLine("entrada no valida");
                    }
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }while(op!=4);
            }
        }
    }
}