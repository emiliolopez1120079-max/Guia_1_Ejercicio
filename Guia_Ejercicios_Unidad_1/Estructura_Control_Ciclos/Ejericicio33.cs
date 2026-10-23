using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejericicio33
    {
        public void Random()
        {
            Random aleatorio = new Random();
            int numSecreto=aleatorio.Next(1, 101);
            int intentoActual=0;
            int num=0;
            bool adivinado=false;
            Console.WriteLine("Adivina el numero del 1 al 100");
            for(int i=1;i<=7;i++)
            {
                Console.Write($"Intento {i}");
                int.TryParse(Console.ReadLine(), out num);
                intentoActual = i;
                // Comprobar si el numero ingresado esta bien
                if(num==numSecreto)
                {
                    Console.WriteLine("adivino el numero");
                    adivinado=true;
                    break;
                }
                // Dar pistas
                else if(num<numSecreto)
                {
                    Console.WriteLine("El numero secreto es MAYOR");
                }
                else
                {
                    Console.WriteLine("El numero secreto es MENOR");
                }
            }
            // Verificar si perdio
            if(!adivinado)
            {
                Console.WriteLine($"Se acabaron los intentos\nEl numero era {numSecreto}");
            }
            // Mostramos el resultado resultado
            Console.WriteLine($"Intentos utilizados: {intentoActual}");
            Console.WriteLine($"Intentos restantes: {7-intentoActual}");
            if(adivinado)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
        }
    }
}