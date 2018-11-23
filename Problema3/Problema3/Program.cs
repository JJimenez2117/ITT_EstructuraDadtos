using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol tree = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            tree.agregars(10, 'A');
            tree.agregars(3, 'B');
            tree.agregars(2, 'D');
            tree.agregars(4, 'E');
            tree.agregars(15, 'C');
            tree.agregars(12, 'J');
            tree.agregars(11, 'H');
            tree.agregars(13, 'F');
            tree.agregars(14, 'I');
            tree.agregars(20, 'G');
            tree.agregars(30, 'K');
            //Impresion en post-orden
            Console.WriteLine("Post-orden: ");
            tree.PostMalone();
            Console.ReadKey();
        }
    }
}
