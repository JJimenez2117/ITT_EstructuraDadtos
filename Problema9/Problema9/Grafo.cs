using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    class Grafo
    {
        private int vertices; //num de vertices
        private List<int>[] adyacencia; //lista de adyacencias
        List<string> Letras = new List<string>();//Lista de letras


        public Grafo(int num) 
        {
            AgregarL();
            vertices = num;
            adyacencia = new List<int>[vertices];//el arreglo de lista y el numero de vertices
            for (int contador = 0; contador < num; contador++)
            {
                adyacencia[contador] = new List<int>();
            }
        }

        public void AgregarL()
        {
            Letras.Add("A");
            Letras.Add("B");
            Letras.Add("C");
            Letras.Add("D");
            Letras.Add("E");
            Letras.Add("F");
            Letras.Add("G");
            Letras.Add("H");
            Letras.Add("I");
        }

        public void AgregarC(int vector1, int vector2) //Metodo para agregar conexiones
        {
            adyacencia[vector1].Add(vector2);
        }

        Grafo Reverso() //Sirve para obtener la raiz al reves 
        {
            Grafo GrafoR = new Grafo(vertices);
            for (int contador = 0; contador < vertices; contador++)
            {
                foreach (int item in adyacencia[contador]) //Agrega la conexion de cada objeto dentro de la lista pero al reves
                {
                    GrafoR.AgregarC(item, contador); 
                }
            }
            return GrafoR; 
        }

        void Print(int vertice, bool[] visitado) //Como dice imprime
        {
            visitado[vertice] = true;
            Console.Write(Letras[vertice] + " ");

            foreach (int item in adyacencia[vertice]) //Imprime cada elemento de la lista adyacencia
            {
                if (visitado[item] == false) 
                {
                    Print(item, visitado);//recursividad bby, si todavia no se imprime
                }
            }
        }

        void LlenaOrdenado(int vertice, bool[] visitado, Stack<int> item) 
        {
            visitado[vertice] = true;

            foreach (int weaita in adyacencia[vertice])
            {
                if (visitado[weaita] == false)
                {
                    LlenaOrdenado(weaita, visitado, item); 
                }
            }
            //El metodo llena la pila
            item.Push(vertice);
        }

        public void ImprimirConexions() //metodo para imprimir conexiones fuertes
        {
            Stack<int> pila = new Stack<int>(); //se guardan los elementoss

            bool[] visitado = new bool[vertices];

            for (int contador = 0; contador < vertices; contador++) 
            {
                visitado[contador] = false;//pone el arreglo como false
            }

            for (int contador = 0; contador < vertices; contador++)
            {
                if (visitado[contador] == false)
                {
                    LlenaOrdenado(contador, visitado, pila); //llena la pila si no ha visitado por el vertice
                }
            }
            //Se obtiene grafo en reverso
            Grafo Graph = Reverso(); 

            for (int contador = 0; contador < vertices; contador++)
            {
                visitado[contador] = false; 
            }

            while (pila.Count > 0) //mientras sea mayor a cero
            {
                int elem = pila.Pop(); 

                if (visitado[elem] == false) //Si ees falso
                {
                    Graph.Print(elem, visitado); //Imprime 
                    Console.WriteLine(); //se separan las conecciones
                }
            }
        }
    }
}