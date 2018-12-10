using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Binaria
{
   
    public class Busqueda
    {

        public void Arreglo()
        {
            int cantidad;
            Console.WriteLine("Escriba la cantidad de elementos que quiere en el arreglo");//se agrega la cantidad de elementos
            cantidad = Convert.ToInt32(Console.ReadLine());
            int[] owo = new int[cantidad];//se crea el arreglo
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba el elemento {0}", i + 1);//se agregan los valores al arreglo
                owo[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(owo);//se ordenan de forma ascendente bien rapido c:
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(owo[i]);//se despliegan ya ordenados
            }

            int mitad;
            mitad = (cantidad) / 2;//se obtiene el valor de en medio
            Console.Write("Escriba el valor que desea buscar");
            int valor = Convert.ToInt32(Console.ReadLine());//Se ingresa el valor a buscar

            if (owo[mitad] == valor)//si el valor de la mitad es el valor buscado
            {
                Console.WriteLine("El valor esta en la posicion {0}", mitad + 1);//se despliega el valor de en medio +1 porque se redondea hacia abajo
            }
            else if (owo[mitad] < valor)//si el valor buscado es mayor que la mitad
            {

                int[] temp = new int[cantidad - mitad];//es el resto de la mitad, ya que si es impar se perderian valores
                for (int contador = mitad; contador < cantidad; contador++)
                {
                    temp[contador - mitad] = owo[contador];//Se ponen en un arreglo temporal que va a ser la mitad del arreglo menor
                }
                for (int i = 0; i < (cantidad - mitad); i++)//Este va a servir para el if, si no se encuentra el valor pues no pasa nada
                {
                    if (temp[i] == valor)//si el valor del arreglo en la posicion del contador
                    {
                        Console.WriteLine("El valor está en la posicion {0}", i + mitad + 1);//se despliega la posicion
                    }
                    else { }//si ponia algo dentro del else iba a aparecer todas las veces que no fuera el valor asi que mejor no puse nada
                }

            }
            else if (owo[mitad] > valor)//Es lo mismo pero cuando el valor buscado es menor a la mitad
            {
                int[] temp = new int[mitad];
                for (int contador = 0; contador < mitad; contador++)
                {
                    temp[contador] = owo[contador];
                }
                for (int i = 0; i < mitad; i++)
                {
                    if (temp[i] == valor)
                    {
                        Console.WriteLine("El valor está en la posicion {0}", i + 1);
                    }
                    else { }
                }

            }

        }
    }
}