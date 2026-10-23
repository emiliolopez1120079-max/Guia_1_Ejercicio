using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio05
    {
        public void Temperaturas()
        {
            float c;
            float f;
            float k;
            Console.WriteLine
            ("Convrsor de temperaturas\n1. celsius a fahrenheit\n2.celsius a kelvin\n3. fahrenheit a celsius\n4. fahrenheit a kelvin\n5. kelvin a celsius\n6. kelvin a fahrenheit");
            int.TryParse(Console.ReadLine(), out int op);
            float temp = 0;
            switch (op)
            {
                case 1:
                Console.Write("Ingrese la temperatura en celsius:");
                float.TryParse(Console.ReadLine(), out c);
                temp = (c*9/5)+32;
                Console.WriteLine($"{c} °C equivale a {temp:F2} °F");
                break;
                case 2:
                Console.Write("Ingrese la temperatura en celsius: ");
                float.TryParse(Console.ReadLine(), out c);
                temp = c+273.15f;
                Console.WriteLine($"{c} °c equivale a {temp:F2} K");
                break;
                case 3:
                Console.Write("Ingrese la temperatura en fahrenheit:");
                float.TryParse(Console.ReadLine(), out f);
                temp = (f-32)*5/9;
                Console.WriteLine($"{f} f equivale a {temp:F2} °C");
                break;
                case 4:
                Console.Write("Ingrese la temperatura en fahrenheit:");
                float.TryParse(Console.ReadLine(), out f);
                temp = ((f-32)*5/9)+273.15f;
                Console.WriteLine($"{f} F equivale a {temp:F2} K");
                break;
                case 5:
                Console.Write("Ingrese la temperatura en kelvin:");
                float.TryParse(Console.ReadLine(), out k);
                temp = k-273.15f;
                Console.WriteLine($"{k} k equivale a {temp:F2} °C");
                break;
                case 6:
                Console.Write("Ingrese la temperatura en kelvin:   ");
                float.TryParse(Console.ReadLine (), out k);
                temp = ((k-273.15f)*9/5)+32;
                Console.WriteLine($"{k} k equivale a {temp:F2} °F");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 6.");
                    break;
            }   
        }
    }
}