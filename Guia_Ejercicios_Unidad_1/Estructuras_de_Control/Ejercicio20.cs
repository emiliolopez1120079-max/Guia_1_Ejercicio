using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio20
    {
        public void Bisiesto()
        {
            Console.Write("Ingrese el año");
            int.TryParse(Console.ReadLine(), out int año);
            Console.Write("Ingrese el mes");
            int.TryParse(Console.ReadLine(), out int mes);
            if(año%4==0&& (año%100!=0||año%400==0))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            if(mes==1||mes==3||mes==5||mes==7||mes==8||mes==10||mes==12)
            {
                Console.WriteLine("El mes tiene 31 dias");
            }
            else if(mes==4||mes==6||mes==9||mes==11)
            {
                Console.WriteLine("El mes tiene 30 dias");
            }
            else if(mes==2)
            {
                if(año%4==0&&(año%100!=0||año%400==0))
                {
                    Console.WriteLine("El mes tiene 29 dias");
                }
                else
                {
                    Console.WriteLine("El mes tiene 28 dias");
                }
            }
            else
            {
                Console.WriteLine("Mes no valido");
            }    
        }
    }
}