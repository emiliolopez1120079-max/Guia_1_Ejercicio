using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio14
    {
        public void Calculadora()
        {
            Console.WriteLine("\nElija una opción escribiendo el numero respectivo:");
            Console.WriteLine("  1. Suma");
            Console.WriteLine("  2. Resta");
            Console.WriteLine("  3. Multiplicación");
            Console.WriteLine("  4. División");
            Console.WriteLine("  5. Módulo");
            int.TryParse(Console.ReadLine(), out int op);
            Console.Write("Ingrese el primer número: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Ingrese el segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);
            switch(op)
            {
            case 1:
                Console.WriteLine($"Resultado:{num1}+{num2}={num1+num2}");
                break;
            case 2:
                Console.WriteLine($"Resultado:{num1}-{num2}={num1-num2}");
                break;
            case 3:
                Console.WriteLine($"Resultado:{num1}*{num2}={num1*num2}");
                break;
            case 4:
                if(num2==0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                else
                {
                    double division = (double)num1/num2;
                    Console.WriteLine($"Resultado:{num1}/{num2}={division}");
                }
                break;
            case 5:
                if(num2==0)
                {
                    Console.WriteLine("Error: No se puede calcular el módulo con divisor cero.");
                }
                else
                {
                    Console.WriteLine($"Resultado:{num1}%{num2}={num1%num2}");
                }
                break;

            default:
                Console.WriteLine("Error: Opción seleccionada no válida.");
                break;
            }
        }
    }
}