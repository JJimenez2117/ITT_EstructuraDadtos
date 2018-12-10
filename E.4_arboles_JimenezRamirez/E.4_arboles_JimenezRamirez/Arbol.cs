using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._4_arboles_JimenezRamirez
{
    class Arbol
    {
        Queue<Nodo> cola = new Queue<Nodo>();
        public void Inicio()
        {
            PArbol("A", 1);// se hace una busqueda binaria para capturar el arbol  
            PArbol("B", 2);
            PArbol("D", 3);
            PArbol("G", 4);
            PArbol("E", 3);
            PArbol("H", 4);
            PArbol("I", 4);
            PArbol("C", 2);
            PArbol("F", 3);
            PArbol("J", 4);
            PArbol("K", 5);


        }

        public void PArbol(string id, int lvl)
        {
            Nodo nodo = new Nodo();
            nodo.Value = id;
            nodo.Haltura = lvl;
            cola.Enqueue(nodo);
        }
        public void ImpresionArbol()
        {
            foreach (var item in cola)
            {
                for (int i = 1; i < item.Haltura; i++)
                {
                    Console.Write("---");
                }
                Console.WriteLine(item.Value);
            }
        }
    }
    public class Nodo
    {
        public string Value { get; set; }
        public int Haltura { get; set; }

    }
}