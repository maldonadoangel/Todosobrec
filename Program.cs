using System;
using System.Threading;


namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxis Switch
            double numero1, numero2, total;
            string titulo = "Bienvenido a mi calculadora";
            //Titulo de ventana
            Console.Title = "Calculadora";

            //Centrar texto en pantalla
            Console.SetCursorPosition((Console.WindowWidth - titulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(titulo);

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Division");
            Console.WriteLine("0. Salir");
            
            Console.WriteLine("Ingrese una de las opciones");
            int opcion = Int16.Parse(Console.ReadLine());

            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero:");
                        numero1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero:");
                        numero2 = Double.Parse(Console.ReadLine());
                        total = numero1 + numero2;
                        Console.WriteLine($"La suma de los numeros es de: {total}");
                        Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un numero:");
                        numero1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero:");
                        numero2 = Double.Parse(Console.ReadLine());
                        total = numero1 - numero2;
                        Console.WriteLine($"La resta de los numeros es de: {total}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un numero:");
                        numero1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero:");
                        numero2 = Double.Parse(Console.ReadLine());
                        if (numero2 == 0)
                        {
                            total = numero2 / numero1;
                            Console.WriteLine($"El total de la division es: {total}");
                        }
                        else
                        {
                            total = numero1 / numero2;
                            Console.WriteLine($"El total de la division es: {total}");

                        }
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }

            } while (opcion != 0);

            
            
        }
    }
}

