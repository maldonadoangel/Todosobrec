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
            int miNumero = 101;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");

            while (aleatorio != miNumero)
            {
                intentos++;
                miNumero = int.Parse(Console.ReadLine());
                if (miNumero < aleatorio)
                {
                    Console.WriteLine("Tu numero es menor, busca uno mayor");
                }
                if (miNumero > aleatorio)
                {
                    Console.WriteLine("Tu numero es mayor, busca uno menor");
                }

            }
            Console.WriteLine($"Felicidades el numero era {aleatorio}, El numero de intentos fueron {intentos}");
            
            
        }
    }
}

