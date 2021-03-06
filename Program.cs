using System;

namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 6.3;
            double valor3 = 7.8;
            Console.WriteLine(Suma(valor1, valor2));
        }
         
         static double Suma(int numero1, double numero2, double numero3 = 0)
        {
            return numero1 + numero2 + numero3;
        }

        //El metodo que llamaria es este debido a que se adapta a los parametros que solicita la funcion main
        static double Suma(int numero1, double numero2)
        {
            return numero1 + numero2;
        }
    }
}
