using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba la cantidad de elementos que desea agregar");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba el {0} elemento", i + 1);
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            QuickAttack pokemon = new QuickAttack();//ya que andamos con la tematica de pokemon
            pokemon.Recorrer(arreglo, 0, arreglo.Length - 1);//se manda que el valor menor es l0 y mayor es el tamaño del arreglo-1
            Console.WriteLine("Los valores acomodados son:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);//Se despliega
            }
            Console.ReadKey();
        }
    }
}
