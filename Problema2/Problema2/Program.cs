using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartas cartas = new Cartas();
            cartas.Ingresar(5);
            cartas.CartasCalcular(5);
            cartas.CartasPrintStation();
            cartas.CartasDom();
            Console.ReadKey();
        }
    }
}
