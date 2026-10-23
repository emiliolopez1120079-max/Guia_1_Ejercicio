using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio21
    {
        public void Fechas()
        {
            int dia, mes, año, dias;
            Console.Write("Ingrese el dia");
            int.TryParse(Console.ReadLine(), out dia);
            Console.Write("Ingrese el mes");
            int.TryParse(Console.ReadLine(), out mes);
            Console.Write("Ingrese el año ");
            int.TryParse(Console.ReadLine(), out año);
            if(mes==1||mes==3||mes==5||mes==7||mes==8||mes==10||mes==12)
            {
                dias=31;
            }
            else if(mes==4||mes==6||mes==9||mes==11)
            {
                dias=30;
            }
            else if(mes==2)
            {
                if(año%4==0&&(año%100!=0||año%400==0))
                {
                    dias=29;
                }    
                else
                {
                    dias=28;
                }
            }
            else
            {
                dias=0;
            }
            if(dia>=1&&dia<=dias&&año>0)
            {
            Console.WriteLine("La fecha es valida");
            }
            else
            {
            Console.WriteLine("La fecha no es valida");
            }
        }
    }
}