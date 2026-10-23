using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Listas
{
    public class Ejercicio50
    {
        public void ParalelasEstudiantes()
        {
            //aqui hacemos el codigo pa ver si se puede manejar las listas paralelas bien :v
            List<string> nombres=new List<string>();
            List<double> promedios=new List<double>();
            int opcion=0;
            do
            {
                Console.WriteLine("\n   Menu de Estudiantes");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Buscar por nombre");
                Console.WriteLine("3. Mostrar el estudiante con mejor promedio");
                Console.WriteLine("4. Listado general");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                //validamos la opcion del menu con tryparse
                if(int.TryParse(Console.ReadLine(),out opcion))
                {
                    if(opcion==1)
                    {
                        Console.Write("Ingrese el nombre del estudiante: ");
                        string nombre=Console.ReadLine();

                        if(!string.IsNullOrEmpty(nombre))
                        {
                            Console.Write("Ingrese el promedio del estudiante: ");
                            double promedio;

                            //validamos que el promedio sea un numero valido entre 0 y 100
                            while(!double.TryParse(Console.ReadLine(),out promedio)||promedio<0||promedio>100)
                            {
                                Console.WriteLine("Tiene que introducir un promedio valido entre 0 y 100");
                            }
                            nombres.Add(nombre); //agregamos el nombre a la lista de nombres
                            promedios.Add(promedio); //agregamos el promedio a la lista de promedios
                            Console.WriteLine("Estudiante agregado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacio");
                        }
                    }
                    else if(opcion==2)
                    {
                        if(nombres.Count>0)
                        {
                            Console.Write("Ingrese el nombre que desea buscar: ");
                            string buscar=Console.ReadLine();
                            bool encontrado=false;
                            int indice=-1;

                            for(int i=0;i<nombres.Count;i++) //recorremos las listas para buscar coincidencia exacta o ignorando mayusculas
                            {
                                if(nombres[i].Equals(buscar,StringComparison.OrdinalIgnoreCase))
                                {
                                    encontrado=true;
                                    indice=i;
                                    break;
                                }
                            }

                            if(encontrado)
                            {
                                Console.WriteLine($"Estudiante encontrado: {nombres[indice]} con promedio {promedios[indice]}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontro un estudiante con ese nombre");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                    }
                    else if(opcion==3)
                    {
                        if(nombres.Count>0)
                        {
                            int mejorIndice=0;
                            double mejorPromedio=promedios[0];

                            for(int i=1;i<promedios.Count;i++) //buscamos el promedio mas alto comparando cada elemento
                            {
                                if(promedios[i]>mejorPromedio)
                                {
                                    mejorPromedio=promedios[i];
                                    mejorIndice=i;
                                }
                            }
                            Console.WriteLine($"El mejor estudiante es {nombres[mejorIndice]} con un promedio de {mejorPromedio}");
                        }
                        else
                        {
                            Console.WriteLine("No hay estudiantes para analizar");
                        }
                    }
                    else if(opcion==4)
                    {
                        if(nombres.Count>0)
                        {
                            Console.WriteLine("\n--- Listado General de Estudiantes ---");
                            for(int i=0;i<nombres.Count;i++) //recorremos ambas listas paralelas para mostrar la info junta
                            {
                                Console.WriteLine($"{i+1}. Nombre: {nombres[i]} - Promedio: {promedios[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay estudiantes registrados en la lista");
                        }
                    }
                    else if(opcion==5)
                    {
                        Console.WriteLine("Saliendo del sistema de estudiantes"); //salimos del sistema sin punto al final
                    }
                    else
                    {
                        Console.WriteLine("Opcion fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no valida");
                }

            }while(opcion!=5);
        }
    }
}