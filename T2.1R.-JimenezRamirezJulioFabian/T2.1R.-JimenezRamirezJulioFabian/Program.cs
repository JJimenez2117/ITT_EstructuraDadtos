using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T2._1R._JimenezRamirezJulioFabian
{
   
    public class Factorial
    {
 
        public int Operacion(int cantidad)
        {
          if(cantidad<=1)
            {
                return 1;
            }
            else
            {
                return cantidad * Operacion(cantidad - 1);

            }
            
        }
        ~Factorial()
        {        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch Tiempo = Stopwatch.StartNew();        
            int cantidad;
            Console.Write("Escriba el numero del cual desea sacar el factorial ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Factorial factorial = new Factorial();
            Console.WriteLine("El resultado del factorial es {0} ",factorial.Operacion(cantidad));
            Console.WriteLine("El tiempo que duró es:\t" + Tiempo.Elapsed);
            Console.ReadKey();
        }
    }
}
