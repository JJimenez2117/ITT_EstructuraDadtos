using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    public class Nodo
    {
        public int dato { get; set; }//propiedades publicas
        public Nodo izq { get; set; }
        public Nodo der { get; set; }

        public Nodo() 
        {   
            this.dato = 0;
            this.der = null;
            this.izq = null;
        }

        public void arbol(Nodo raiz, int dato)
        {   
            Nodo nuevoNodo = new Nodo();//Se inicializa un nuevo nodo
            nuevoNodo.dato = dato;
            Nodo apuntador = raiz;
            int direccion = 0;

            while (direccion != 4)
            {               
                if (nuevoNodo.dato < apuntador.dato)//Compara y decide su direccion
                    direccion = 1;
                else
                    direccion = 2;
   
                switch (direccion)//Se ingresa un nodo conectado al nodo actual
                {
                    case 1: //Si va para la izquierda
                        if (apuntador.izq != null) //Si hay un dato se mueve
                            apuntador = apuntador.izq;
                        else //Sino existe se asigna 
                        {
                            apuntador.izq = nuevoNodo;
                            direccion = 4;
                        }
                        break;
                    case 2: //Lo mismo pero con derecha
                        if (apuntador.der != null)  
                            apuntador = apuntador.der;
                        else  
                        {
                            apuntador.der = nuevoNodo;
                            direccion = 4;
                        }
                        break;
                }
            }
        }
        public void inorden(Nodo nodoActual)//Se crea el metodo INORDEN owo
        {
            if (nodoActual != null)//Se va a recorrer el arbol si existe 
            {
                inorden(nodoActual.izq); //Se va a recorrer a la izquierda
                Console.Write("{0},", nodoActual.dato); //Se imprime
                inorden(nodoActual.der); //Ahora a la derecha
            }
        }
    }
}
