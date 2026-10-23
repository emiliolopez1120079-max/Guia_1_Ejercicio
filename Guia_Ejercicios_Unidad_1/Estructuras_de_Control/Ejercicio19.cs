using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio19
    {
        public void Triangulos()
        {
            Console.Write("Ingrese la longitud del cateo A");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Ingrese la longitud del cateto B");
            double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Ingrese la longitud de la hipotenuza");
            double.TryParse(Console.ReadLine(), out double c);
            if(a>0&&b>0&&c>0&&(a+b>c)&&(a+c>b)&&(b+c>a))
            {
                string clasLado;
                if(a==b&&b==c)
                {
                    clasLado="Equilátero";
                }
                else if(a==b||b==c||a==c)
                {
                    clasLado="Isósceles";
                }
                else
                {
                    clasLado="Escaleno";
                }
                double x=0,y=0,z=0;
                if(a>=b&&a>=c)
                {
                    x=b;y=c;z=a;
                }
                else if(b>=a&&b>=c)
                {
                    x=a;y=c;z=b;
                }
                string clasAngulo;
                double tolerancia=0.0001;
                if(Math.Abs((x*x+y*y)-(z*z))<tolerancia)
                {
                    clasAngulo="Rectángulo";
                }
                else if((x*x+y*y)>(z*z))
                {
                    clasAngulo="Acutángulo";
                }
                else
                {
                    clasAngulo="Obtusángulo";
                }
                Console.WriteLine($"Por sus lados:   {clasLado}");
                Console.WriteLine($"Por sus ángulos: {clasAngulo}");
            }
            else
            {
                Console.WriteLine("Los valores ingresados no forman un triángulo");
            }
        }
    }
}