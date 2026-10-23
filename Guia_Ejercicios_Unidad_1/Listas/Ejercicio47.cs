namespace Guia_Ejercicios_Unidad_1.Listas
{
    public class Ejercicio47
    {
        public void NotasLista()
        {
            //aqui hacemos el codigo pa ver si se puede calcular las notas bien :v
            List<double> notas=new List<double>();
            string respuesta="s";
            //ciclo para registrar notas hasta que el usuario decida parar
            while(respuesta=="s"||respuesta=="S")
            {
                Console.Write("Ingrese una nota: ");
                if(double.TryParse(Console.ReadLine(),out double nota))
                {
                    if(nota>=0&&nota<=100)
                    {
                        notas.Add(nota); //agregamos la nota a la lista dinamica
                    }
                    else
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 100");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no valida");
                }
                Console.Write("Desea ingresar otra nota s/n: ");
                respuesta=Console.ReadLine();
            }
            if(notas.Count>0)
            {
                double suma=0;
                double maxima=notas[0];
                double minima=notas[0];
                //recorremos la lista para calcular suma, maxima y minima
                foreach(double nota in notas)
                {
                    suma+=nota;
                    if(nota>maxima)
                    {
                        maxima=nota;
                    }
                    if(nota<minima)
                    {
                        minima=nota;
                    }
                }
                double promedioOriginal=suma/notas.Count;
                Console.WriteLine($"Promedio original={promedioOriginal}");
                Console.WriteLine($"Nota maxima={maxima}");
                Console.WriteLine($"Nota minima={minima}");
                //eliminamos la nota mas baja de la lista
                notas.Remove(minima);
                if(notas.Count>0)
                {
                    double sumaNueva=0;
                    for(int i=0;i<notas.Count;i++) //sumamos las notas restantes
                    {
                        sumaNueva+=notas[i];
                    }

                    double promedioNuevo=sumaNueva/notas.Count;
                    Console.WriteLine($"Nuevo promedio sin la nota mas baja={promedioNuevo}");
                }
                else
                {
                    Console.WriteLine("No quedan notas despues de eliminar la mas baja");
                }
            }
            else
            {
                Console.WriteLine("No se registraron notas");
            }
        }
    }
}