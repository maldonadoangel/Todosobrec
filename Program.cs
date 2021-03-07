using System;
using System.Threading;


namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, verifiquemos tu edad....");
            Thread.Sleep(2000);
            Console.WriteLine("Ingrese su edad:");
            int edad = Int16.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine($"Su edad es de: {edad} años es Menor de edad, le recomendamos cuidarse.");
            }
            else if(edad <= 59)
            {
                Console.WriteLine($"Su edad es de: {edad} años, Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Debe cuidarse ya es una persona de la tercera edad");
            }
            
        }
    }
}

