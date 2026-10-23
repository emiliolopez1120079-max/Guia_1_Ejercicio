namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio26
    {
        public void cicloExponente()
        {
            Console.WriteLine("Ingrese el exponente que desea utilizar:");
            double.TryParse(Console.ReadLine(), out double expo);
            
            Console.WriteLine("Ingrese el número base:");
            double.TryParse(Console.ReadLine(), out double num);
            double final=1;
            if (expo>0)
            {
                for (int i=0;i<expo;i++)
                {
                    final*=num;
                }
                Console.WriteLine($"El resultado es: {final:F2}");
            }
            else if (expo<0)
            {
                double expoPositivo=-expo; 
                double denominador=1;
                for(int i=0;i<expoPositivo;i++)
                {
                    denominador*=num;
                }
                if(denominador!=0)
                {
                    final=1/denominador;
                }
                else
                {
                    Console.WriteLine(" No se puede dividir por cero");
                    return;
                }
                Console.WriteLine($"El resultado es: {final}");
            }
        }
    }
}