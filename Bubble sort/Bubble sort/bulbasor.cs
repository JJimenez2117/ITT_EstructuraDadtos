using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    public class Bulbasor
    {
        public void Charmander()
        {
            int temp;//Variable temporal
            int num;//variable para cantidad de elementos
            Console.WriteLine("Escriba la cantidad de elementos de desea ingresar");
            num = Convert.ToInt32(Console.ReadLine());
            int[] wea = new int[num];
            for (int i = 0; i < num; i++)//Se ingresa los valores
            {
                Console.WriteLine("Ingrese el {0} numero", i+1);
                wea[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int contador = 0; contador < wea.Length; contador++)
            {
                for (int i = 1; i < wea.Length; i++)
                {
                    if (wea[i - 1] > wea[i])//El if es por si el anterior es mayor que el siguiente numero
                    {//si sí se cambia de posicion
                        temp = wea[i];//Se guarda como valor actual
                        wea[i] = wea[i - 1];//Se cambia el valor de posicion
                        wea[i - 1] = temp;//Ahora se cambia el otro valor
                    }
                }
            }
            for (int i = 0; i < wea.Length; i++)//Se despliega el arreglo
            {
                Console.Write(wea[i]);
            }
        }
    }
}
