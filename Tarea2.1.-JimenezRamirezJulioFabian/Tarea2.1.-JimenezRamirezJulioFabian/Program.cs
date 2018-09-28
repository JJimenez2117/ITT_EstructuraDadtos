using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tarea2._1._JimenezRamirezJulioFabian
{
    public class Factorial
    {
     
        public int Operacion()
        {
            int valor=1, cantidad;
            Console.Write("Escriba el numero del cual desea sacar factorial ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int contador=1;contador<=cantidad;contador++)
            {
                valor = valor * contador;
            }
            return valor;
        }
        ~Factorial()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch Tiempo = Stopwatch.StartNew();
            Factorial fac = new Factorial();
            Console.WriteLine("El resultado del factorial es {0} ",fac.Operacion());
            Console.WriteLine("El tiempo que duró es:\t" + Tiempo.Elapsed);

            Console.ReadKey();
            

        }
    }
}
