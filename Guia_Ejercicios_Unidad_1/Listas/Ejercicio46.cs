namespace Guia_Ejercicios_Unidad_1.Listas
{
    public class Ejercicio46
    {
        public void GestionarProductos()
        {
           // la lista xd
            List<string> productos=new List<string>();
            int op=0;
            do
            {
                Console.WriteLine("\n    Menu de Productos");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar lista ordenada");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                //validamos la entrada de enteros para evitar errores
                if(int.TryParse(Console.ReadLine(),out op))
                {
                    if(op==1)
                    {
                        Console.Write("Ingrese el nombre del producto: ");
                        string? nuevo=Console.ReadLine();
                        if(!string.IsNullOrEmpty(nuevo))
                        {
                            if(!productos.Contains(nuevo)) //evitamos duplicados usando Contains
                            {
                                productos.Add(nuevo);
                                Console.WriteLine("Producto agregado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("El producto ya existe en la lista");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El nombre no puede estar vacio");
                        }
                    }
                    else if(op==2)
                    {
                        if(productos.Count>0)
                        {
                            Console.Write("Ingrese el nombre del producto que desea eliminar: ");
                            string? eliminar=Console.ReadLine();
                            if(productos.Contains(eliminar))
                            {
                                productos.Remove(eliminar); //eliminamos el producto si se encuentra
                                Console.WriteLine("Producto eliminado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("El producto no esta registrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay productos para eliminar");
                        }
                    }
                    else if(op==3)
                    {
                        if(productos.Count>0)
                        {
                            Console.Write("Ingrese el nombre del producto que desea buscar: ");
                            string buscar=Console.ReadLine();
                            if(productos.Contains(buscar)) //buscamos el producto con Contains
                            {
                                Console.WriteLine("El producto si se encuentra en la lista");
                            }
                            else
                            {
                                Console.WriteLine("El producto no se encuentra");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay productos para buscar");
                        }
                    }
                    else if(op==4)
                    {
                        if(productos.Count>0)
                        {
                            productos.Sort(); //ordenamos la lista alfabeticamente
                            Console.WriteLine("\n   Lista de Productos Ordenada");
                            for(int i=0;i<productos.Count;i++) //recorremos para mostrar los elementos ordenados
                            {
                                Console.WriteLine($"{i+1}. {productos[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay productos en la lista");
                        }
                    }
                    else if(op==5)
                    {
                        Console.WriteLine("Saliendo del gestor de productos"); //salimos del sistema sin punto al final
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

            }while(op!=5);
        }
    }
}