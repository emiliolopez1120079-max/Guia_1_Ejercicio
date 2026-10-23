using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio16
    {
        public void Notas()
        {
        Console.Write("Ingrese la nota final (0-100): ");
        int.TryParse(Console.ReadLine(), out int nota);
        if (nota<0||nota>100)
        {
            Console.WriteLine("\nError: La nota ingresada está fuera del rango válido (0 a 100).");
        }
        else
        {
            string letra;
            string descripcion,estado;
           if (nota >= 90)
            {
                letra="A";
                descripcion="Excelente";
                estado="Aprobado";
            }
            else if(nota>=80)
            {
                letra="B";
                descripcion="Muy Bueno";
                estado="aprobado";
            }
            else if (nota>=70)
            {
                letra="C";
                descripcion="Satisfactorio";
                estado="aprobado";
            }
            else if(nota>=65)
            {
                letra="D";
                descripcion="Aprobado Mínimo";
                estado="aprobado";
            }
            else
            {
                letra="F";
                descripcion="Reprobado";
                estado="reprobado";
            }
            Console.WriteLine($"Nota obtenida: {nota}%");
            Console.WriteLine($"Calificación:  {letra}");
            Console.WriteLine($"Descripción:   {descripcion}");
            Console.WriteLine($"Estado:        {estado}");

        }
        }
    }
}