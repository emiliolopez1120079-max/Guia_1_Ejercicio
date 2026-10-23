namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio41
    {
        public void TemperaturasSemana()
        {
            //aqui hacemos el codigo pa ver si se puede registrar el clima bien
            double[] temperaturas=new double[7];
            string[] dias={"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
            double suma=0;
            //pedimos la temperatura pa cada dia de la semana
            for(int i=0;i<temperaturas.Length;i++)
            {
                Console.WriteLine($"Ingrese la temperatura del dia {dias[i]}");
                while(!double.TryParse(Console.ReadLine(),out temperaturas[i]))
                {
                    Console.WriteLine("Tiene que introducir un numero valido");
                }
                suma+=temperaturas[i];
            }
            //calculamos el promedio semanal dividiendo entre siete
            double promedio=suma/temperaturas.Length;
            double masCaluroso=temperaturas[0];
            double masFrio=temperaturas[0];
            string diaCaluroso=dias[0];
            string diaFrio=dias[0];
            //recorremos con foreach para sacar el mas alto y el mas bajo
            for(int i=0;i<temperaturas.Length;i++)
            {
                if(temperaturas[i]>masCaluroso)
                {
                    masCaluroso=temperaturas[i];
                    diaCaluroso=dias[i];
                }
                if(temperaturas[i]<masFrio)
                {
                    masFrio=temperaturas[i];
                    diaFrio=dias[i];
                }
            }
            //mostramos los datos principales sin punto al final
            Console.WriteLine($"Promedio semanal={promedio:F2}");
            Console.WriteLine($"Dia mas caluroso={diaCaluroso} ({masCaluroso:F2})");
            Console.WriteLine($"Dia mas frio={diaFrio} ({masFrio:F2})");
            //checamos cuales dias pasaron del promedio semanal
            Console.WriteLine("Dias sobre el promedio:");
            for(int i=0;i<temperaturas.Length;i++)
            {
                if(temperaturas[i]>promedio)
                {
                    Console.WriteLine($"{dias[i]} con {temperaturas[i]}");
                }
            }
            //calculamos la variacion de temperatura entre un dia y el siguiente
            Console.WriteLine("Variacion entre dias consecutivos:");
            for(int i=0;i<temperaturas.Length-1;i++)
            {
                double variacion=Math.Abs(temperaturas[i+1]-temperaturas[i]);
                Console.WriteLine($"De {dias[i]} a {dias[i+1]}={variacion:F2}");
            }
        }
    }
}