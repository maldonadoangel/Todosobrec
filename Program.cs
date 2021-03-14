using System;
using System.Threading;


namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(1, 100);
            int contador = 0;
            int miNumero = 0;


            do
            {
                contador++;
                try
                {
                    Console.WriteLine("Ingresa un numero del 1 al 100");
                    miNumero = int.Parse(Console.ReadLine());
                }catch(FormatException ex)
                {
                    Console.WriteLine("No haz introducido un valor valido. Se toma como numero inicial el 0 debido a que no introdujo un valor valido");
                }
                if (miNumero < aleatorio)
                {
                    Console.WriteLine("El numero es menor, aumenta su valor");
                } else if (miNumero > aleatorio)
                {
                    Console.WriteLine("El numero es mayor, disminuye su valor");
                }


            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! El numero era {aleatorio}, tu numeros de intentos es de: {contador}");

            
            
        }
    }
}

