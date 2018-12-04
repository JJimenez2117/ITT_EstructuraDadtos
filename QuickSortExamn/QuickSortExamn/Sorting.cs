using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortExamn
{
    class Sorting
    {
        public int ObtenerPivote(int[] arreglo, int Izquierda, int Derecha) //Aquí es donde se acomodan los elementos, se toma el pivote y los
        {                                                                       //menores que este van a la izquierda y los mayores a la derecha
            double Pivote = arreglo[Derecha]; //Se toma como pivote el último elemento del arreglo

            int Pequeno = (Izquierda - 1); //Indice del elemento mas pequeño
            for (int contador = Izquierda; contador < Derecha; contador++) //Se hace el recorrido desde la izquierda hasta la derecha
            {
                if (arreglo[contador] <= Pivote) //Si el elemento de la izquierda es menor que el pivote o igual a este
                {
                    Pequeno++; //Se incrementa el indice

                    int temp = arreglo[Pequeno]; //Se guarda el elemento del arreglo con el indice "Pequeno"
                    arreglo[Pequeno] = arreglo[contador]; //Se hace el cambio de el valor, similar al arreglo de burbuja
                    arreglo[contador] = temp; //Se regresa el valor guardado al arreglo
                }
            }

            int temporal = arreglo[Pequeno + 1];  //Similar a lo anterior, se guarda un valor (esta vez de la derecha)
            arreglo[Pequeno + 1] = arreglo[Derecha]; //Se hace el intercambio
            arreglo[Derecha] = temporal; //Se retorna el valor guardado

            return Pequeno + 1; //Retorna el indice incrementado en 1
        }

        public void QuickSort(ref int[] arreglo, int Izquierda, int Derecha) //Es donde se hace el método recursivo
        {
            if (Izquierda < Derecha) //Si la Izquierda es menor que la derecha
            {
                //particion es el indice que se recibe de el metodo ObtenerPivote
                int particion = ObtenerPivote(arreglo, Izquierda, Derecha);

                QuickSort(ref arreglo, Izquierda, particion - 1); //Se hace la recursividad con la Derecha disminuida en 1
                QuickSort(ref arreglo, particion + 1, Derecha); //Se hace la recursividad con la izquierda aumentada, con esto se va recorriendo el arreglo
            }                                               //Mientras se va acomodando en el metodo ObtenerPivote
        }
    }
}
