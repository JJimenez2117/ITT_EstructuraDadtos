using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    public class Process
    {
        public void RadixSort(LinkedList<int> linkedList)
        {
            bool Terminado = false;//Se crea un bool que dice que terminado es falso
            int posicion = 0;//posicion del digito

            var digitos = new List<Queue<int>>();//Se crea una cola 
            Agregar(digitos);

            while (!Terminado)
            {
                Terminado = true;

                foreach (int valor in linkedList)
                {
                    int elemento = ObtenerD(valor, posicion);
                    if (elemento > 0)
                    {
                        Terminado = false;
                    }

                    digitos[elemento].Enqueue(valor);
                }

                var avanzar = linkedList.First;
                foreach (var item in digitos)
                {
                    while (item.Count > 0 && avanzar != null)
                    {
                        avanzar.Value = item.Dequeue();
                        avanzar = avanzar.Next;
                    }
                }

                posicion++;
            }

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        static int ObtenerD(int valor, int posicion)//Se obtiene el digito
        {
            int Dig = (valor / (int)Math.Pow(10, posicion)) % 10;
            return Dig;
        }

        static void Agregar(List<Queue<int>> elemento)
        {
            for (int i = 0; i < 10; i++)
            {
                var cola = new Queue<int>();//
                elemento.Add(cola);
            }
        }
    }
}
