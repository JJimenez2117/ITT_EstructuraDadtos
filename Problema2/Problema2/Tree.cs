using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class MasterNode//Arbolito adornado 
    {
        public int dato; //Guarda el valor que toma el nodo
        public MasterNode izq { get; set; }
        public MasterNode der { get; set; }
    }

    public class Tree
    {
        MasterNode raiz; //Se crea el objeto raiz

        public Tree()
        {
            raiz = null; // inicializa raiz en nulo
        }

        public void Insertar(int info)
        {
            MasterNode nuevo= new MasterNode(); //se incializa el nuevo nodo
            nuevo.dato = info; //Se agrega el valor al nodo
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo; //Si es nulo se agrega
            else //sino se acomodan
            {
                MasterNode anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null)
                {
                    anterior = recorrido;
                    if (info < recorrido.dato)
                        recorrido = recorrido.izq;
                    else
                        recorrido = recorrido.der;
                }
                if (info < anterior.dato)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void Imprimir(MasterNode recorrido) //Se imprime arbol de adornado 
        {
            if (recorrido != null)
            {
                Console.Write(recorrido.dato + " ");
                Imprimir(recorrido.izq);
                Imprimir(recorrido.der);
            }
        }

       


       
    }

}
