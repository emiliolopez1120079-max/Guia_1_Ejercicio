using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructuras_de_Control
{
    public class Ejercicio22
    {
        public void Cajero_Automatico()
        {
            int saldo=5000;
            int b20, b50, b100, b500;
            Console.Write("Ingrese el monto a retirar");
            int.TryParse(Console.ReadLine(), out int retiro);
            if(retiro%20==0&&retiro<=saldo&&retiro>0)
            {
                saldo-=retiro;
                b500=retiro/500;
                retiro%=500;
                b100=retiro/100;
                retiro%=100;
                b50=retiro/50;
                retiro%=50;
                b20=retiro/20;
                Console.WriteLine($"Billetes de 500: {b500}");
                Console.WriteLine($"Billetes de 100: {b100}");
                Console.WriteLine($"Billetes de 50: {b50}");
                Console.WriteLine($"Billetes de 20: {b20}");
                Console.WriteLine($"Saldo restante: {saldo}");
            }
            else
            {
                Console.WriteLine("Retiro no valido");
            }
        }
    }
}