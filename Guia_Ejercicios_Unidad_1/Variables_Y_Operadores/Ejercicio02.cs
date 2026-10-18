using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio02
    {
        public void Calculadora_IMC()
        {
            Console.WriteLine($"Ingrese el peso en (kg)");
            float.TryParse(Console.ReadLine(), out float peso);
            Console.WriteLine($"Ingrese su altura(m)");
            float.TryParse(Console.ReadLine(), out float altura);
            float IMC = peso/(altura*altura);
            Console.WriteLine($"El IMC es de: {IMC:F2}");
            if(IMC<=18.5)
            {
                 Console.WriteLine($"Esta en bajo peso");
            }
            else if(IMC<=24.9)
            {
                Console.WriteLine($"Esta en un peso normal");
            }
            else if(IMC<=29.9)
            {
                Console.WriteLine($"Esta en Sobrepeso");
            }
            else
            {
                Console.WriteLine($"Esta en etapa de obecidad");
            }
        }
    }
}