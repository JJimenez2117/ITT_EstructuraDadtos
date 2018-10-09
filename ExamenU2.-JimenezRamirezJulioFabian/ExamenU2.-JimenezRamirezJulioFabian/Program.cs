using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            string cadena;
            do
            {
                try
                {
                    Console.Write("Ingrese un número de 7 dígitos o más: ");
                    cadena = Console.ReadLine();
                    if (cadena.Length < 7)
                        throw new Exception("Por favor ingrese mas de 7 dígitos");

                    Recursividad llamar = new Recursividad();

                    Console.WriteLine("El resultado es: {0}", llamar.Sumar(cadena, cadena.Length, 0));

                    Console.Write("¿Desea seguir usando el programa?\nPresione 1 para continuar, cualquier otra tecla para salir: ");
                    opcion = Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                    opcion = "1";
                }
            } while (opcion == "1");

        }
    }
}

