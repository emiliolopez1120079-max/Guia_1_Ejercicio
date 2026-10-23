using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Unidad_1.Estructura_Control_Ciclos
{
    public class Ejercicio34
    {
        public void ValidarContraseña()
        {
            bool valido = false;
            Console.WriteLine("Registro de contraseña segura");
            Console.WriteLine("Requisitos: minimo 8 caracteres, una mayuscula, una minuscula, un numero y un caracter especial");
            while(!valido)
            {
                Console.Write("\nIngrese su contraseña: ");
                string pass=Console.ReadLine();
                if(pass==null)pass="";//evalua si es uela solo sera un espacio vacio
                // Banderas para cada validar si cumplen :v
                bool tieneLongitud=pass.Length>=8;
                bool tieneMayus=false;
                bool tieneMinus=false;
                bool tieneNumero=false;
                bool tieneEspecial=false;
                //esto evalua si cumplen las condiciones
                for(int i = 0; i < pass.Length; i++)
                {
                    char c = pass[i];
                    if(char.IsUpper(c))
                    tieneMayus=true;
                    if(char.IsLower(c))
                    tieneMinus=true;
                    if(char.IsDigit(c))
                    tieneNumero=true;
                    if(!char.IsLetterOrDigit(c))
                    tieneEspecial=true;
                }
                //Ver si cumple con todas las reglas
                if(tieneLongitud&&tieneMayus &&tieneMinus&& tieneNumero&&tieneEspecial)
                {
                    Console.WriteLine("Contraseña creada");
                    valido=true;
                }
                else
                {
                    Console.WriteLine("La contraseña no cumple, le falta lo siguiente:");
                    if(!tieneLongitud) Console.WriteLine("- Minimo 8 caracteres");
                    if(!tieneMayus) Console.WriteLine("- Al menos una letra mayuscula");
                    if(!tieneMinus) Console.WriteLine("- Al menos una letra minuscula");
                    if(!tieneNumero) Console.WriteLine("- Al menos un numero");
                    if(!tieneEspecial) Console.WriteLine("- Al menos un caracter especial");
                }
            }
        }
    }
}