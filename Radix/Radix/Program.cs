using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            Process radix = new Process();
            LinkedList<int> owo = new LinkedList<int>();
            Console.WriteLine("Escriba la cantidad de elementos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                int read = 0;
                Console.Write("Escriba el elemento {0}: ", i + 1);
                read = Convert.ToInt32(Console.ReadLine());
                owo.AddLast(read);
            }
           


            radix.RadixSort(owo);
            

            Console.ReadKey();

        }
    }
}
