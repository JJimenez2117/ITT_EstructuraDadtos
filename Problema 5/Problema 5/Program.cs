using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            raiz.dato = "enologia";
            //Ingresar arbol
            raiz.arbol(raiz, "frenologia");
            raiz.arbol(raiz, "campanologia");
            raiz.arbol(raiz, "ornitologia");
            raiz.arbol(raiz, "ictilogia");
            raiz.arbol(raiz, "limnologia");
            raiz.arbol(raiz, "alquimia");
            raiz.arbol(raiz, "astrologia");
            Console.WriteLine("Arbol:");//se imprime el arbol
            raiz.Imprimir(raiz);
            Console.ReadKey();
        }
    }
}
