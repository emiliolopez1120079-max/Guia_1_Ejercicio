using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio07
    {
        public void TiempoTranscurrido()
        {
            Console.WriteLine($"Introdusca uan hora en formato de 0 a 23");
            int.TryParse(Console.ReadLine(), out int h1);
            Console.Write("Los minutos de 0 a 59: ");
            int.TryParse(Console.ReadLine(), out int m1);
            Console.Write("Los segundos de 0 a 59: ");
            int.TryParse(Console.ReadLine(), out int s1);

            Console.WriteLine($"Introdusca una segunda hora en formato de 0 a 23");
            int.TryParse(Console.ReadLine(), out int h2);
            Console.Write("Los minutos de 0 a 59: ");
            int.TryParse(Console.ReadLine(), out int m2);
            Console.Write("Los segundos de 0 a 59: ");
            int.TryParse(Console.ReadLine(), out int s2);
            if(h1>23||h1<0||h2>23||h2<0||m1>59||m1<0||m2>59||m2<0||s2>59||s2<0||s1>59||s1<0)
            {
                Console.WriteLine($"Datos invalidos, intentelo otra vez");
            }
            else
            {
            int cont1 = (h1*3600) + (m1*60) + s1;
            int cont2 = (h2*3600) + (m2*60) + s2;
            int dif;
            if(cont1>cont2)
            {
                dif = cont1-cont2;
            }
            else
            {
                dif = cont2-cont1;
            }
            int horas = dif/3600;
            int minutos = (dif%3600)/60;
            int segundos = (dif%3600)%60;
            Console.WriteLine($"Tiempo transcurrido: {horas}h {minutos}m {segundos}s");
            }
        }
    }
}