using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3._2_JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
           //Se crea la cola
            Queue Cola = new Queue();
            //Se agregan elementos a la cola con Enqueue
            Cola.Enqueue("1"); 
            Cola.Enqueue("2"); 
            Cola.Enqueue("3");

            for (int i= 0; i < 3; i++)
            {//Dequeue retorna un valor y despues lo elimina de la cola
                Console.WriteLine(Cola.Dequeue());  
            }
            //Limita la capacidad de la cola
            Cola.TrimToSize(); 

            Console.WriteLine(Cola.Count); 
            Console.ReadKey();
        }
    }
}
