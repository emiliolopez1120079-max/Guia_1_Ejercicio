namespace Guia_Ejercicios_Unidad_1.Arreglos_Unidimensionales
{
    public class Ejercicio42
    {
        public void Busqueda_Ordenamiento()
        {
            //aqui hacemos el codigo pa ver si se puede ordenar 
            int[] numeros=new int[10];
            for(int i=0;i<numeros.Length;i++)//llenamos el arreglo con diez numeros enteros pedidos
            {
                Console.WriteLine($"Ingrese el numero {i+1}");
                while(!int.TryParse(Console.ReadLine(),out numeros[i]))
                {
                    Console.WriteLine("Tiene que introducir un numero valido");
                }
            }
            //buscamos de forma lineal
            Console.WriteLine("Ingrese el numero que desea buscar");
            int.TryParse(Console.ReadLine(),out int buscar);
            bool encontrado=false;
            int posicion=-1;
            for(int i=0;i<numeros.Length;i++)
            {
                if(numeros[i]==buscar)
                {
                    encontrado=true;
                    posicion=i;
                    break;
                }
            }
            if(encontrado)
            {
                Console.WriteLine($"El numero se encontro en la posicion {posicion+1}");
            }
            else
            {
                Console.WriteLine("El numero no se encontro en el arreglo");
            }
            for(int i=0;i<numeros.Length-1;i++) //ordenar de forma ascendente usando metodo burbuja
            {
                for(int j=0;j<numeros.Length-i-1;j++)
                {
                    if(numeros[j]>numeros[j+1])
                    {
                        int temp=numeros[j];
                        numeros[j]=numeros[j+1];
                        numeros[j+1]=temp;
                    }
                }
            }
            //encontrar el segundo mayor recorriendo desde atras
            int mayor=numeros[numeros.Length-1];
            int segundoMayor=numeros[0];
            for(int i=numeros.Length-2;i>=0;i--)
            {
                if(numeros[i]<mayor)
                {
                    segundoMayor=numeros[i];
                    break;
                }
            }
            Console.WriteLine($"El segundo mayor es={segundoMayor}");//aqui ense;a el segundo mayor
            Console.WriteLine("Elementos en posiciones pares:"); //mostrar los elementos ubicados en posiciones pares
            for(int i=0;i<numeros.Length;i+=2)
            {
                Console.WriteLine($"Posicion {i}={numeros[i]}");
            }
        }
    }
}