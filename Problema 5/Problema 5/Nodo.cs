using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    public class Nodo
    {
        public string dato { get; set; }//propiedades
        public Nodo izq { get; set; }
        public Nodo der { get; set; }

        public Nodo()
        {
            this.dato = "";
            this.izq = null;
            this.der = null;
        }

        public void arbol(Nodo raiz, string Dato)
        {   //Inicializa el nuevo nodo
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = Dato;
            Nodo apuntador = raiz;
            int direccion = 0;
            int i = 0;

            byte[] datoBytes = Encoding.ASCII.GetBytes(Dato);//Se genera un arreglo de bytes con el codigo ascci (obviamente me ayudaron con este arreglo)
            byte[] apuntadorBytes = Encoding.ASCII.GetBytes(apuntador.dato);//Pero nos va a servir para ordenarlo alfabeticamente

            int datonm = datoBytes[0];
            int apuntadornm = apuntadorBytes[0];

            while (direccion != 4)
            {
                apuntadorBytes = Encoding.ASCII.GetBytes(apuntador.dato);
                apuntadornm = apuntadorBytes[0];
                while (datonm == apuntadornm)//Compara las letras y si es igual toma la siguiente
                {
                    i++;
                    datonm = datoBytes[i];
                    apuntadornm = apuntadorBytes[i];
                }
                //decide la direccion             
                if (datonm < apuntadornm)
                    direccion = 1;
                else
                    direccion = 2;
                switch (direccion)//Ingresa el nodo dependiendo a su lado
                {
                    case 1: //Si va a izquierda
                        if (apuntador.izq != null) //Si es solo un dato, lo mueve
                            apuntador = apuntador.izq;
                        else //Si no aqui se asigna
                        {
                            apuntador.izq = nuevoNodo;
                            direccion = 4;
                        }
                        break;
                    case 2: //Si va a derecha
                        if (apuntador.der != null)  //Si es solo un dato, lo mueve
                            apuntador = apuntador.der;
                        else  //Si no existe aqui se asigna
                        {
                            apuntador.der = nuevoNodo;
                            direccion = 4;
                        }
                        break;
                }
            }
        }

        public void Imprimir(Nodo nodoActual)
        {
            if (nodoActual != null)
            {   //Imprime el nodo y sus ramas
                Console.WriteLine("\t{1}<-{0}->{2}", nodoActual.dato, (nodoActual.izq == null ? "null" : nodoActual.izq.dato.ToString()), (nodoActual.der == null ? "null" : nodoActual.der.dato.ToString()));
                Imprimir(nodoActual.izq);//recursividad baby
                Imprimir(nodoActual.der);
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
