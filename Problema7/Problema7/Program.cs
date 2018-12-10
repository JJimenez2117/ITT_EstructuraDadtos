using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            raiz.dato = "Raiz";//Se agrega la raiz 

            Nodo vacio1 = new Nodo();//Ingresamos el arbol
            Nodo vacio2 = new Nodo();
            Nodo vacio3 = new Nodo();
            Nodo vacio4 = new Nodo();
            Nodo vacio5 = new Nodo();
            Nodo vacio6 = new Nodo();
            Nodo vacio7 = new Nodo();
            Nodo a = new Nodo();
            a.dato = "a";
            Nodo e = new Nodo();
            e.dato = "e";
            Nodo i = new Nodo();
            i.dato = "i";
            Nodo k = new Nodo();
            k.dato = "k";
            Nodo o = new Nodo();
            o.dato = "o";
            Nodo p = new Nodo();
            p.dato = "p";
            Nodo u = new Nodo();
            u.dato = "u";

            raiz.izq = vacio1;//Enlazamos el arbol
            raiz.der = vacio3;
            vacio1.izq = vacio2;
            vacio1.der = i;
            vacio2.izq = a;
            vacio2.der = e;
            vacio3.der = vacio4;
            vacio4.izq = vacio5;
            vacio4.der = vacio6;
            vacio5.izq = k;
            vacio5.der = o;
            vacio6.der = vacio7;
            vacio7.izq = p;
            vacio7.der = u;

            a.Rutas(raiz, "a");//Buscamos las rutass
            e.Rutas(raiz, "e");
            i.Rutas(raiz, "i");
            k.Rutas(raiz, "k");
            o.Rutas(raiz, "o");
            p.Rutas(raiz, "p");
            u.Rutas(raiz, "u");
            Console.ReadKey();
        }
    }
}
