using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            raiz.dato = "El";//se agrega la raiz
            raiz.arbol(raiz, "rapido");
            raiz.arbol(raiz, "zorro");
            raiz.arbol(raiz, "marron");
            raiz.arbol(raiz, "salta");
            raiz.arbol(raiz, "sobre");
            raiz.arbol(raiz, "el");
            raiz.arbol(raiz, "perro");
            raiz.arbol(raiz, "perezoso");
            Console.WriteLine("Arbolito: El rápido zorro marrón salta sobre el perro perezoso.");//Se imprime el arbol de la frase 
            raiz.Imprimir(raiz);
            Console.ReadKey();
        }
    }
}
