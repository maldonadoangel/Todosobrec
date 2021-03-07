using System;

namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18 && edad <= 59)
            {
                Console.WriteLine($"Su edad es de: {edad} años, por lo tanto usted es un adulto");
            }
            if (edad >= 60)
            {
                Console.WriteLine($"Su edad es de: {edad} años, por lo tanto usted es una persona de la tercera edad");
            }
            if (edad <= 17)
            {
                Console.WriteLine($"Su edad es de: {edad} años, por lo tanto eres un niño o un joven");
            }
        }
    }
}

