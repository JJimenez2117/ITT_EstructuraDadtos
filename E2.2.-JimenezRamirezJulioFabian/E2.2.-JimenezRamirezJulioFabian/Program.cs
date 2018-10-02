using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2._2_JimenezRamirezJulioFabian
{
    public class Fibonacci
    {

        public int OperacionR(int cantidad)
        {
            if (cantidad <= 0)
            {
                return 1;
            }

            else
            {
                
                return OperacionR(cantidad - 2) + OperacionR(cantidad - 1);
               



            }

        }
        public void Iteracion()
        {
            Stopwatch Tiempo = Stopwatch.StartNew();
            int inicial = 0, final = 1, suma = 0, cantidad;
            Console.Write("Escriba el numero hasta el cual desea realizar el fibonacci ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int contador = 1; contador <= cantidad; contador++)
            {
                inicial = suma;
                suma = final;
                final = inicial + final;
                Console.Write(suma + ",");
            }
            Console.WriteLine("El tiempo que duró la iteracion es:\t" + Tiempo.Elapsed);

        }

        ~Fibonacci()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            int cantidad;
            Console.Write("Escriba el numero hasta el cual desea realizar el fibonacci ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.OperacionR(cantidad);
            fibonacci.Iteracion();
            Console.ReadKey();
        }
    }

}
