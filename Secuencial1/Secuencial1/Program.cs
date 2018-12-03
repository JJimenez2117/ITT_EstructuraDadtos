using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial1
{
    class Program
    {
        static void Main(string[] args)
        {//Dos programas en uno OWO
            SequenceOWO oWO = new SequenceOWO();//Se instancia la clase ( creo que asi se dice), pero pues nos deja utilizar los metodos de la otra clase pues
            Console.Write("Escriba 1 para realizar una busqueda de un numero o 2 para una busqueda de letras");
            int opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                oWO.owo();
            }
            else
            {
                oWO.uwu();
            }
            Console.ReadKey();

        }
    }
}
