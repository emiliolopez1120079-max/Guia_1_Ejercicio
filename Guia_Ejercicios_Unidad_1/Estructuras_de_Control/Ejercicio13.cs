using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio13
    {
        public void Switchs()
        {
            Console.WriteLine($"Introdusca un numero entero");
            int.TryParse(Console.ReadLine(), out int numero);
            string dia;
            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Número inválido, debe ser entre 1 y 7";
                    break;
            }
            string dia2 = numero switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Número inválido, debe ser entre 1 y 7"
            }; 
            Console.WriteLine($"Usando Switch Clásico: {dia}");
            Console.WriteLine($"Usando Expresión Switch: {dia2}");
        }
    }
}