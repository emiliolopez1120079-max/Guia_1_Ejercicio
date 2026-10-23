using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Listas
{
    public class Ejericio45
    {
        public void MenuTareas()
        {
            //aqui hacemos el codigo pa ver si se puede administrar las tareas bien :v
            List<string> tareas=new List<string>();
            int opcion=0;

            do
            {
                Console.WriteLine("Menu de tareas");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar todas las tareas numeradas");
                Console.WriteLine("3. Eliminar una tarea por su numero");
                Console.WriteLine("4. Mostrar el total de tareas pendientes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                if(int.TryParse(Console.ReadLine(),out opcion))
                {
                    if(opcion==1)
                    {
                        Console.Write("Ingrese la descripcion de la tarea: ");
                        string nuevaTarea=Console.ReadLine();
                        if(!string.IsNullOrEmpty(nuevaTarea))
                        {
                            tareas.Add(nuevaTarea); //agregamos la nueva tarea a la lista dinamica
                            Console.WriteLine("Tarea agregada correctamente");
                        }
                        else
                        {
                            Console.WriteLine("La tarea no puede estar vacia");
                        }
                    }
                    else if(opcion==2)
                    {
                        if(tareas.Count>0)
                        {
                            Console.WriteLine("\n    Lista de Tareas");
                            for(int i=0;i<tareas.Count;i++) //recorremos la lista para mostrar cada tarea con su numero correspondiente
                            {
                                Console.WriteLine($"{i+1}. {tareas[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay tareas registradas");
                        }
                    }
                    else if(opcion==3)
                    {
                        if(tareas.Count>0)
                        {
                            Console.WriteLine("\n   Tareas Actuales");
                            for(int i=0;i<tareas.Count;i++)
                            {
                                Console.WriteLine($"{i+1}. {tareas[i]}");
                            }

                            Console.Write("Ingrese el numero de la tarea que desea eliminar: ");
                            if(int.TryParse(Console.ReadLine(),out int numeroEliminar))
                            {
                                if(numeroEliminar>=1&&numeroEliminar<=tareas.Count)
                                {
                                    tareas.RemoveAt(numeroEliminar-1); //eliminamos el elemento usando el indice ajustado
                                    Console.WriteLine("Tarea eliminada correctamente");
                                }
                                else
                                {
                                    Console.WriteLine("Numero de tarea fuera de rango");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no valida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay tareas para eliminar");
                        }
                    }
                    else if(opcion==4)
                    {
                        Console.WriteLine($"Total de tareas pendientes: {tareas.Count}"); //mostramos la cantidad actual de elementos en la lista
                    }
                    else if(opcion==5)
                    {
                        Console.WriteLine("Saliendo del gestor de tareas"); //salimos del sistema sin punto al final
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