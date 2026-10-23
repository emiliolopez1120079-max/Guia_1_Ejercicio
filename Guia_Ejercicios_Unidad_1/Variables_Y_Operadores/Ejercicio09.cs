using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Variables_Y_Operadores
{
    public class Ejercicio09
    {
        public void Salarios()
        {
            double salario;
            Console.Write($"Ingrese las horas trabajadas(sin contar las horas extras): ");
            double.TryParse(Console.ReadLine(), out double horas);
            Console.Write($"Ingrese la tarifa por hora: ");
            double.TryParse(Console.ReadLine(), out double tarifa);
            Console.Write($"Ingrese las horas extra: ");
            double.TryParse(Console.ReadLine(), out double hextras);
        if(hextras>44)
        {
            salario = (44*tarifa)+(hextras*tarifa*1.5);
            Console.WriteLine($"Horas normales: 44");
            Console.WriteLine($"Pago normal: {44*tarifa}");
            Console.WriteLine($"Horas extras: {hextras}");
            Console.WriteLine($"Pago extra: {hextras*tarifa*1.5}");
        }
        else
        {
            salario = horas * tarifa;
            Console.WriteLine($"Horas normales: {horas}");
            Console.WriteLine($"Pago normal: {salario}");
            Console.WriteLine($"Horas extras: 0");
            Console.WriteLine($"Pago extra: 0");
        }
            Console.WriteLine($"Salario semanal total: {salario}");
        }
    }
}