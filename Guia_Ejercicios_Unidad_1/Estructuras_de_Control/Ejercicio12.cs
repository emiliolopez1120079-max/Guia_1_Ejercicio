using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio12
    {
        public void MayorMenor()
        {
            int menor,mayor;
            Console.WriteLine($"Introduzca tres numeros");
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);
            if(num1>num2&&num1>num3)
            {
                mayor=num1;
            }
            else if(num2>num1&&num2>num3)
            {
                mayor=num2;
            }
            else
            {
                mayor=num3;
            }
            if (num1<num2&&num1<num3)
            {
                menor=num1;
            }
            else if(num2<num1&&num2<num3)
            {
                menor=num2;
            }
            else
            {
                menor=num3;
            }
            Console.WriteLine($"El número MAYOR es: {mayor}");
            Console.WriteLine($"El número MENOR es: {menor}");
        }
    }
}