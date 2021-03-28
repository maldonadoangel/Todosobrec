using System;
using System.Threading;


namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contadorLinea = 0;

                string ruta = @"C:\Users\Games\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(ruta);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contadorLinea++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            //Para cerrar el streamReader para que no consuma tantos recursos, se recomienda siempre usarlo cuando son archivos o base de datos
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }
                Console.WriteLine("El archivo se cerro con exito.");
            }
          

            
            
        }
    }
}

