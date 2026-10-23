using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio39
    {
        public void CalificacionesArreglo()
        {
            //aqui hacemos el codigo pa ver si se puede calcular bien :v
            double suma=0;
            double maxima=0;
            double minima=0;
            int aprobados=0;
            int reprobados=0;
            //pedimos cuantas notas va a meter el usuario
            Console.WriteLine("Ingrese la cantidad de calificaciones");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)||n<=0)
            {
                Console.WriteLine("Cantidad no valida, intente de nuevo");
            }
            //revisamos que no sea cero o negativo por si las moscas
            if(n<=0)
            {
                Console.WriteLine("Cantidad no valida");
            }
            else
            {
                double[] notas = new double[n];
                //llenando el arreglo con un for normalito
                for(int i=0;i<notas.Length;i++)
                {
                    Console.WriteLine($"Ingrese la calificacion {i+1}");
                    while(!double.TryParse(Console.ReadLine(), out notas[i]))
                    {
                        Console.WriteLine("Tiene que introducir un numero valido");
                    }
                }
                //inicializamos con la primera poscision para comparar
                maxima=notas[0];
                minima=notas[0];
                //recorremos con foreach pa sacar todo de un solo golpe
                foreach(double nota in notas)
                {
                    suma+=nota;
                    //vemos cual es la nota mas alta
                    if(nota>maxima)
                    {
                        maxima=nota;
                    }
                    //y aqui la mas baja
                    if(nota<minima)
                    {
                        minima=nota;
                    }
                    //contamos si pasan o no con el 60
                    if(nota>=60)
                    {
                        aprobados++;
                    }
                    else
                    {
                        reprobados++;
                    }
                }
                //calculamos el promedio dividiendo la suma total
                double promedio=suma/notas.Length;
                double sumaDiferencias=0;
                //otro for para sacar la desviacion estandar con la formula
                for(int i=0;i<notas.Length;i++)
                {
                    sumaDiferencias+=Math.Pow(notas[i]-promedio,2);
                }
                double desviacionEstandar=Math.Sqrt(sumaDiferencias/notas.Length);
                //imprimimos los resultados finales en consola sin punto al final
                Console.WriteLine($"Promedio={promedio} Maxima={maxima} Minima={minima}");
                Console.WriteLine($"Aprobados={aprobados} Reprobados={reprobados}");
                Console.WriteLine($"Desviacion estandar={desviacionEstandar}");
            }
        }
    }
}