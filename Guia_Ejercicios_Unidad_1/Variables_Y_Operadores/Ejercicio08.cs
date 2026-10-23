using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio08
    {
        public void DesgloseBilletes()
        {
            Console.WriteLine($"Ingrese una cantidad de Dinero");
            int.TryParse(Console.ReadLine(), out int dinero);
            if(dinero>0)
            {
                Console.WriteLine($"Billetes de 500: {dinero/500}");
                dinero%= 500;
                Console.WriteLine($"Billetes de 100: {dinero/100}");
                dinero%= 100;
                Console.WriteLine($"Billetes de 50: {dinero/50}");
                dinero%= 50;
                Console.WriteLine($"Billetes de 20: {dinero/20}");
                dinero%= 20;
                Console.WriteLine($"Billetes de 10: {dinero/10}");
                dinero%= 10;
                Console.WriteLine($"Billetes de 5: {dinero/5}");
                dinero%= 5;
                Console.WriteLine($"Billetes de 2: {dinero/2}");
                dinero%= 2;
                Console.WriteLine($"Billetes de 1 {dinero/1}");
            }
        }
    }
}