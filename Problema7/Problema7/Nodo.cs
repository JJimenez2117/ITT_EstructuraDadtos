using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    public class Nodo
    {        
        public string dato { get; set; }//properties para que vea que se inglesss
        public Nodo izq { get; set; }
        public Nodo der { get; set; }
        public string ruta;

        public Nodo() 
        {   
            this.dato = "-";
            this.izq = null;
            this.der = null;
        }

        public void Rutas(Nodo nodoActual, string dato)
        {
            if (nodoActual != null)//Si el nodo elegido no existe vemos si es una hoja, si sí se busca el nodo
            {   
                if (nodoActual.izq != null || nodoActual.der != null)
                {
                    //Si va a la izquiera se agrega un 0
                    ruta = ruta + "0 ";
                    Rutas(nodoActual.izq, dato);
                    //Si va a la derecha pues un 1
                    ruta = ruta + "1 ";
                    Rutas(nodoActual.der, dato);
                    //Cuando termina se regresa restando
                    if (ruta.Length >= 2)
                        ruta = ruta.Remove(ruta.Length - 2);
                }
                else if (nodoActual.dato == dato)
                {   //Si es el nodo que queremos se imprime
                    Console.WriteLine("Ruta " + dato + ": " + ruta);
                }
                else
                    ruta = ruta.Remove(ruta.Length - 2);
            }
            else //si no existe pues se regresa
                ruta = ruta.Remove(ruta.Length - 2);

        }
    }

}
