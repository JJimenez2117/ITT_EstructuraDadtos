using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EC._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ejemplo = new Stack();

            ejemplo.Push(1);
            ejemplo.Push(82);
            ejemplo.Push(5);

            if (ejemplo.Contains(5))//Permite saber si existe el elmento dentro de la pila
                Console.WriteLine("5");
            else
                Console.WriteLine("No contiene 5");

            ejemplo.ToString();//Convierte un elemento en string

            if (ejemplo.GetType() == typeof(Stack))//Se puede saber si un objeto es del tipo que desea
                Console.WriteLine("Es el tipo que quiere");
            else
                Console.WriteLine("No es el tipo");

            Console.WriteLine(ejemplo.ToArray().ElementAt(1) + "\n");//Convierte la pila en arreglo

            IEnumerator enumerator = ejemplo.GetEnumerator();//Se consigue el enumerador de la pila
            while (enumerator.MoveNext())
            {
                Object objeto = enumerator.Current;
                Console.WriteLine(objeto);
            }
            Console.ReadKey();
        }
    }
}