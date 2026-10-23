using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio35
    {
        public void MenuPatrones()
        {
            int opcion=0;
            // Ciclo principal para mostrar el menu repetidamente
            do
            {
                Console.WriteLine("Elija la opcion que desee usar");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Triangulo invertido");
                Console.WriteLine("3. Rombo");
                Console.WriteLine("4. Cuadrado hueco");
                Console.WriteLine("5. Piramide numerica");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opcion: ");
                if(int.TryParse(Console.ReadLine(),out opcion))
                {
                    if(opcion>=1&&opcion<=5)
                    {
                        Console.Write("Ingrese el tamaño del patron: ");
                        if(int.TryParse(Console.ReadLine(),out int tam)&&tam>0)
                        {
                            Console.WriteLine();
                            // Validar cual patron generar segun la opcion elegida
                            if(opcion==1)
                            {
                                GenerarTriangulo(tam);
                            }
                            else if(opcion==2)
                            {
                                GenerarTrianguloInvertido(tam);
                            }
                            else if(opcion==3)
                            {
                                GenerarRombo(tam);
                            }
                            else if(opcion==4)
                            {
                                GenerarCuadradoHueco(tam);
                            }
                            else if(opcion==5)
                            {
                                GenerarPiramideNumerica(tam);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tamaño no valido");
                        }
                    }
                    else if(opcion==6)
                    {
                        Console.WriteLine("Saliendo del programa");
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

            }while(opcion!=6);
        }
        private void GenerarTriangulo(int n)
        {
            // Dibuja un triangulo alineado a la izquierda
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private void GenerarTrianguloInvertido(int n)
        {
            // Dibuja un triangulo invertido de mayor a menor
            for(int i=n;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private void GenerarRombo(int n)
        {
            // Parte superior del rombo
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Parte inferior del rombo
            for(int i=n-1;i>=1;i--)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private void GenerarCuadradoHueco(int n)
        {
            // Dibuja los bordes de un cuadrado dejando espacios adentro
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(i==1||i==n||j==1||j==n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        private void GenerarPiramideNumerica(int n)
        {
            // Dibuja una piramide con numeros que incrementan por fila
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}