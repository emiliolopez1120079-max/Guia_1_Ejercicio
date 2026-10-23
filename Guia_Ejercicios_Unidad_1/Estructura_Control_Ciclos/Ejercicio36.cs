using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio36
    {
        public void Calculadora()
        {
            double resultadoActual = 0;
            bool primerCalculo = true;
            int opcion = 0;
            do
            {
                Console.WriteLine("\n--- Calculadora Avanzada ---");
            if (primerCalculo)
            {
                Console.WriteLine("Estado actual: Sin resultado previo");
            }
            else
            {
                Console.WriteLine($"Resultado actual: {resultadoActual}");
            }
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raiz cuadrada");
            Console.WriteLine("7. Porcentaje");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opcion: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion>=1&&opcion<=7)
                {
                    double primerNumero=0;
                    bool usaResultadoPrevio=false;
                    // Si hay resultado previo, preguntar si se usa como base
                    if (!primerCalculo)
                    {
                        Console.Write("¿Desea usar el resultado anterior como base? (s/n): ");
                        string respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S")
                        {
                            primerNumero = resultadoActual;
                            usaResultadoPrevio = true;
                        }
                    }
                    // Pedir el primer numero solo si no se usa el resultado previo
                    if (!usaResultadoPrevio)
                    {
                        Console.Write("Ingrese el numero: ");
                        if(!double.TryParse(Console.ReadLine(), out primerNumero))
                        {
                            Console.WriteLine("Numero no valido");
                            continue;
                        }
                    }
                    // Operacion de un solo numero
                    if(opcion==6)
                    {
                        if(primerNumero>=0)
                        {
                            resultadoActual=Math.Sqrt(primerNumero);
                            Console.WriteLine($"Resultado: {resultadoActual}");
                            primerCalculo=false;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede calcular la raiz de un numero negativo");
                        }
                    continue;
                    }
                    // Operaciones que requieren un segundo numero
                    Console.Write("Ingrese el segundo numero: ");
                    if(double.TryParse(Console.ReadLine(), out double segundoNumero))
                    {
                        if(opcion==1)
                        {
                            resultadoActual=primerNumero+segundoNumero;
                        }
                        else if (opcion==2)
                        {
                            resultadoActual=primerNumero-segundoNumero;
                        }
                        else if (opcion==3)
                        {
                            resultadoActual=primerNumero*segundoNumero;
                        }
                        else if (opcion==4)
                        {
                            if (segundoNumero!=0)
                            {
                                resultadoActual=primerNumero/segundoNumero;
                            }
                            else
                            {
                                Console.WriteLine("Error: Division entre cero no permitida");
                                continue;
                            }
                        }
                        else if(opcion==5)
                        {
                            resultadoActual=Math.Pow(primerNumero,segundoNumero);
                        }
                        else if (opcion==7)
                        {
                            resultadoActual =(primerNumero *segundoNumero)/100;
                        }
                        Console.WriteLine($"Resultado: {resultadoActual}");
                        primerCalculo=false;
                    }
                    else
                    {
                        Console.WriteLine("Segundo numero no valido");
                    }
                }
                 else if (opcion==8)
                {
                    Console.WriteLine("Saliendo de la calculadora");
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
            } while (opcion!=8);
        }
    }
}