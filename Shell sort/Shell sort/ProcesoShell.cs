using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_sort
{
    public class ProcesoShell
    {
         int[] vector;

        public void Valores()
        {
            int cantidad;
            Console.Write("Cuantos elementos desea ingresar:");
            cantidad=Convert.ToInt32(Console.ReadLine());
            vector = new int[cantidad];
            for (int i = 0; i< vector.Length; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Shell()
        {
            int k= 0,aux=0,temp=0,contador=0;
            k = vector.Length / 2;//es el tamaño de los altos que va a dar
            while (k > 0)//Va a seguir recorriendo hasta que el tamaño de los saltos sea mayor a 0
            {
                aux = 1;
                while (aux != 0)//Si ya no se puede realizar el proceso, pasa a dividir el salto otra vez
                {
                    aux = 0;//si no sucede se queda como 0 y va a salir para dividir el salto
                    contador = 1;
                    while (contador <= (vector.Length - k))//Va a realizar el proceso mientras sea menor o igual al tamaño del arreglo para compararlos
                    {
                        if (vector[contador - 1] > vector[(contador - 1) + k])//si el valor contando los saltos es menor se cambia
                        {
                            temp = vector[(contador - 1) + k];
                            vector[(contador - 1) + k] = vector[contador - 1];
                            vector[(contador - 1)] = temp;
                            aux = 1;//si estos sucede, va a hacer el que nos ayude a que se repita el proceso
                        }
                        contador++;
                    }
                }
                k = k / 2;//se va seguir dividiendo hasta que esten todos acomodados, que suele terminar en 1
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Valores");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i] );
            }
            Console.ReadKey();
        }
    }
}
