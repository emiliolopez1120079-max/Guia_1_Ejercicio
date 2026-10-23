using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio04
    {
        public void Area_Perimetro()
        {
            float area;
            float perimetro;
            Console.WriteLine($"Elija la forma geometrica que desea calcular");
            Console.WriteLine($"1.Circulo\n2.triangulo\n3.Rectangulo\n4.Trapecio");
            int.TryParse(Console.ReadLine(), out int op);
            switch(op)
            {
                case 1: 
                Console.WriteLine($"Ingrese el radio de el circulo");
                float.TryParse(Console.ReadLine(), out float radio);
                if(radio<0)
                    {
                        Console.WriteLine($"Dato ingreasado incorrecto");
                        break;
                    }
                Console.WriteLine($"Area:{Math.PI*radio*radio:F2}\nPerimetro{2*Math.PI*radio:F2}");
                break;
                case 2:
                Console.WriteLine($"Ingrese los tres lados de el triangulo");
                float.TryParse(Console.ReadLine(), out float a);
                float.TryParse(Console.ReadLine(), out float b);
                float.TryParse(Console.ReadLine(), out float c);
                if(a<0||b<0||c<0)
                    {
                        Console.WriteLine($"Dato ingreasado incorrecto");
                        break;
                    }
                perimetro = (a+b+c);
                area = (perimetro/2);
                area = (float)Math.Sqrt(area*(area-a)*(area-b)*(area-c));
                Console.WriteLine($"El Area es:{area} y el Perimetro:{perimetro}");
                break;
                case 3:
                Console.WriteLine($"Ingrese el largo del rectangulo");
                float.TryParse(Console.ReadLine(), out float largo);
                Console.WriteLine($"Ingrese el ancho del rectangulo");
                float.TryParse(Console.ReadLine(), out float ancho);
                if(largo<0||ancho<0)
                    {
                        Console.WriteLine($"Dato ingreasado incorrecto");
                        break;
                    }
                area = largo*ancho;
                perimetro = 2   *(largo+ancho);
                Console.WriteLine($"El Area es:{area} y el Perimetro:{perimetro}");
                break;
                case 4:
                Console.WriteLine($"Ingrese la base menor del trapecio");
                float.TryParse(Console.ReadLine(), out float base1);
                Console.WriteLine($"Ingrese la base mayor del trapecio");
                float.TryParse(Console.ReadLine(), out float base2);
                Console.WriteLine($"Ingrese la altura del trapecio");
                float.TryParse(Console.ReadLine(), out float altura);
                Console.WriteLine($"Ingrese el primer lado del trapecio");
                float.TryParse(Console.ReadLine(), out float lado1);
                Console.WriteLine($"Ingrese el segundo lado trapecio");
                float.TryParse(Console.ReadLine(), out float lado2);
                if(base1<0||base2<0||altura<0||lado1<0||lado2<0)
                    {
                        Console.WriteLine($"Dato ingreasado incorrecto");
                        break;
                    }
                area = ((base1 + base2)*altura)/2;
                perimetro = base1+base2+lado1+lado2;
                Console.WriteLine($"El Area es:{area} y el Perimetro:{perimetro}");
                break;
                default: 
                Console.WriteLine($"Opcion invalida");
                break;
                
            }
        }
    }
}