using System;
using System.Threading;


namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;

            Console.WriteLine("Bienvenido al programa de numeros primos");
            try
            {
                Console.WriteLine("Ingrese un numero entero");
                numero = int.Parse(Console.ReadLine());

            }
            catch (Exception ex){
                Console.WriteLine("Error ingreso un valor incorrecto, Se asignara el valor de 2");
                numero = 2;

            }

            if (numero > 1)
            {
                for (int i = 1; i<=numero; i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }
            }

            if(contador == 2)
            {
                Console.WriteLine("Su numero es primo.");
            }
            else
            {
                Console.WriteLine("Su numero es compuesto");
            }
        
          

            
            
        }
    }
}

