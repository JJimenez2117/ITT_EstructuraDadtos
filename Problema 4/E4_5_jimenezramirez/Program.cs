using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_5_jimenezramirez
{
  

    class Program
    {
        static void Main(string[] args)
        {   
            Nodo raiz = new Nodo();
            raiz.dato = "banana";//se agrega la raiz           
            raiz.arbol(raiz, "melocoton");
            raiz.arbol(raiz, "manzana");
            raiz.arbol(raiz, "pera");
            raiz.arbol(raiz, "coco");
            raiz.arbol(raiz, "mango");
            raiz.arbol(raiz, "papaya"); 
            Console.WriteLine("El arbol de frutas: ");//se imprime el arbol
            raiz.Imprimir(raiz);

            Console.ReadKey();
        }
    }
}