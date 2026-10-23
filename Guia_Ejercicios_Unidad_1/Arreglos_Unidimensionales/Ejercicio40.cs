namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio40
    {
        public void nums()
        {
            //aqui hacemos el codigo pa ver si se puede contar la frecuencia bien :v
            Random rand=new Random();
            int[] numeros=new int[20];
            //llenamos el arreglo con numeros aleatorios del 1 al 10
            for(int i=0;i<numeros.Length;i++)
            {
                numeros[i]=rand.Next(1,11);
            }
            int maxFrecuencia=0;
            int minFrecuencia=21; 
            int MasFrecuente=0;
            int MenosFrecuente=0;
            //recorremos del 1 al 10 para ver cuantas veces sale cada uno
            for(int i=1;i<=10;i++)
            {
                int contador=0;
                //otro for para buscar en todo el arreglo
                for(int j=0;j<numeros.Length;j++)
                {
                    if(numeros[j]==i)
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"Número {i}: {contador} veces");
                //vemos cual se repite mas
                if(contador>maxFrecuencia)
                {
                    maxFrecuencia=contador;
                    MasFrecuente=i;
                }
                //y aqui cual sale menos
                if(contador<minFrecuencia)
                {
                    minFrecuencia=contador;
                    MenosFrecuente=i;
                }
            }
            //mostramos los campeones al final sin punto en consola
            Console.WriteLine($"\nEl número más frecuente es: {MasFrecuente} ({maxFrecuencia} veces)");
            Console.WriteLine($"El número menos frecuente es: {MenosFrecuente} ({minFrecuencia} veces)");  
        }
    }
}