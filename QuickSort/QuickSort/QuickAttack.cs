using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickAttack
    {


        public int Partir(int[] arreglo, int menor, int mayor)
        {
            int temp;
            int pivote = arreglo[mayor];//se toma como mayor el pivote
            int indice = menor - 1;

            for (int conta = menor; conta <= mayor - 1; conta++)//Se realiza el proceso de comparacion
            {
                if (arreglo[conta] <= pivote)//si el elemento es menor o igual al pivote
                {
                    indice++;//el indice aumenta
                    temp = arreglo[indice];//Se utiliza el temporal para poder acomodar los valores
                    arreglo[indice] = arreglo[conta];
                    arreglo[conta] = temp;
                }
            }

            temp = arreglo[indice + 1];//Este acomoda los numeros mayores al pivote
            arreglo[indice + 1] = arreglo[mayor];
            arreglo[mayor] = temp;
            return indice+1 ;
        }

    

        public void Recorrer(int[] arreglo, int menor, int mayor)//Este es un metodo recursivo
        {
            int contador;
            if (menor < mayor)
            {
                contador= Partir(arreglo, menor, mayor);//Este mas que contador es un indice

                Recorrer(arreglo, menor, contador - 1);//Se hace recursividad y se decrece de los numeros mayores, para que se recorra el arreglo
                Recorrer(arreglo, contador + 1, mayor);//Se hace recursividad y se aumenta el indice para que el arreglo vaya recorriendose
            }                                          //hacia adelante
        }

    }
}
