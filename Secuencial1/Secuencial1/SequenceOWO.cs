using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial1
{
    public class SequenceOWO
    {
        public void owo()
        {
            
            Console.Write("Escriba el tamaño del arreglo");//Se escribe el tamaño del arreglo
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[cantidad];//Se crea el arreglo
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba la cantidad {0}", i + 1);
                arreglo[i] = Convert.ToInt32(Console.ReadLine());//Se guardan los valores en el arreglo
            }
            Console.WriteLine("Escriba la cantidad que desea buscar");
            int busqueda = Convert.ToInt32(Console.ReadLine());//Se guarda la cantidad que se quiere buscar
            if (BuscarInt(arreglo, cantidad, busqueda) == -1)//Si el valor que retorna es -1 
            {
                Console.WriteLine("El valor que buscó no se encuentra");//se despliega que no se encuentra el valor buscado
            }
            else
            {
                Console.Write("La posicion del numero buscado es {0}", BuscarInt(arreglo, cantidad, busqueda) + 1);//sino se despliega la posicion del valor
            }
        }
        public void uwu()
        {

            Console.Write("Escriba el tamaño del arreglo");//Se escribe el tamaño del arreglo
            int cantidad = Convert.ToInt32(Console.ReadLine());
            string[] arreglo = new string[cantidad];//Se crea el arreglo
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba la frase o letra {0}", i + 1);
                arreglo[i] = Console.ReadLine();//Se guardan los valores en el arreglo
            }
            Console.WriteLine("Escriba la frase o letra que desea buscar");
            string busqueda = Console.ReadLine();//Se guarda la cantidad que se quiere buscar
            if (BuscarStr(arreglo, cantidad, busqueda) == -1)//Si el valor que retorna es -1 
            {
                Console.WriteLine("El valor que buscó no se encuentra");//se despliega que no se encuentra el valor buscado
            }
            else
            {
                Console.Write("La posicion de la frase o letra buscada es {0}", BuscarStr(arreglo, cantidad, busqueda) + 1);//sino se despliega la posicion del valor
            }
        }

        public int BuscarInt(int[] arreglo,int tam, int valor)//Se reciben el arreglo, despues el tamaño del arreglo y al final el valor buscado
        {
            for (int i = 0; i < tam; i++)//se recorre el arreglo con el ciclo
            {
                if(arreglo[i]==valor)//Si un elemento del arreglo es igual al buscado 
                {
                    return i;//se retorna la posicion del elemento en el arreglo, esto solo retorna el primero que salga si es que el elemento se repite
                }
            }
            return -1;//retornamos -1 para no tener confusiones de que sea una posicion del arreglo y así desplegar en el main si es que se encuentra
        }
        public int BuscarStr(string[] arreglo, int tam, string valor)//Se reciben el arreglo, despues el tamaño del arreglo y al final el valor buscado
        {
            for (int i = 0; i < tam; i++)//se recorre el arreglo con el ciclo
            {
                if (arreglo[i] == valor)//Si un elemento del arreglo es igual al buscado 
                {
                    return i;//se retorna la posicion del elemento en el arreglo, esto solo retorna el primero que salga si es que el elemento se repite
                }
            }
            return -1;//retornamos -1 para no tener confusiones de que sea una posicion del arreglo y así desplegar en el main si es que se encuentra
        }
    }
}
