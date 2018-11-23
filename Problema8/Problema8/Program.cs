using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            raiz.dato = -1;//se agrega la root
            raiz.arbol (raiz, 0);//first arbol
            raiz.arbol(raiz, 2);
            raiz.arbol(raiz, -2);
            raiz.arbol(raiz, 3);
            raiz.arbol(raiz, 6);
            raiz.arbol(raiz, -3);
            raiz.arbol(raiz, 5);
            raiz.arbol(raiz, 1);
            raiz.arbol(raiz, 4);
            Console.WriteLine("Arbol One:");
            raiz.inorden(raiz);

            //segundo tree
            Nodo raiz2 = new Nodo();
            raiz2.dato = -1;
            //Ingresar arbol
            raiz.arbol(raiz, 7);
            raiz.arbol(raiz, 4);
            raiz.arbol(raiz, 11);
            raiz.arbol(raiz, 5);
            raiz.arbol(raiz, -8);
            raiz.arbol(raiz, 15);
            raiz.arbol(raiz, -3);
            raiz.arbol(raiz, -2);
            raiz.arbol(raiz, 6);
            raiz.arbol(raiz, 10);
            raiz.arbol(raiz, 3);
            Console.WriteLine("\nArbol Two:");
            raiz.inorden(raiz);
            Console.ReadKey();
        }
    }
}
