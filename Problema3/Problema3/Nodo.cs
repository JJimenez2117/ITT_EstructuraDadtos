using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    public class Nodo
    {
        public int dato { get; set; } //Propiedades
        public Nodo der { get; set; }
        public Nodo izq { get; set; }
        public char letra;
    }

    public class Arbol
    {
        Nodo raiz;

        public Arbol()
        {
            raiz = null;

        }

        public void agregars(int dato, char letra)
        {
            Nodo nuevo = new Nodo();//Se incializa el nuevo nodo 
            nuevo.dato = dato;
            nuevo.letra = letra;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)//
                raiz = nuevo;
            else
            {
                Nodo ant = null, ruta;
                ruta = raiz;
                while (ruta != null)//Se compara para ver donde se acomoda
                {
                    ant = ruta;
                    if (dato < ruta.dato)
                        ruta = ruta.izq;
                    else
                        ruta = ruta.der;
                }
                if (dato < ant.dato)
                    ant.izq = nuevo;
                else
                    ant.der = nuevo;
            }
        }
        private void PostMalone(Nodo recorrido) //Se imprime en post
        {
            if (recorrido != null)
            {
                PostMalone(recorrido.izq);
                PostMalone(recorrido.der);
                Console.Write(recorrido.letra + "->");
            }
        }
        public void PostMalone()
        {
            PostMalone(raiz);
            Console.WriteLine();
        }
    }

}
