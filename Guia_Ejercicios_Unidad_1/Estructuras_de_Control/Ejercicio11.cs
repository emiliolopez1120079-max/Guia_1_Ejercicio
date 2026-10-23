using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio11
    {
        public void Positivo_NEgativo_Cero()
        {
            Console.WriteLine($"Introdusca un numero entero");
            int.TryParse(Console.ReadLine(), out int numero);
            if(numero>0)
            {
                Console.WriteLine($"Es postivo");
            }
            else if(numero<0)
            {
                Console.WriteLine($"Es negativo");
            }
            else
            {
                Console.WriteLine($"Es cero");
            }
            string mensaje = numero%2 == 0 ? "Es par" : "es impar";
            Console.WriteLine(mensaje);
        }
    }
}