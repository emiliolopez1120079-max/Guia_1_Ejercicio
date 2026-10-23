using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio15
    {
         public void Calculadora_Switch()
        {        
          Console.Write("Ingrese una sola letra: ");
          string letra=Console.ReadLine();
          switch (letra )
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine($"\n{letra} es una VOCAL.");
                    break;
                default:
                    Console.WriteLine($"\n{letra} es una CONSONANTE.");
                    break;
            }
        }   
     }
}