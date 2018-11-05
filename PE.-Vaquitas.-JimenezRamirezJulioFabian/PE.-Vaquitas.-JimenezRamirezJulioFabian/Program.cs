using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._Vaquitas._JimenezRamirezJulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se quiere llegar del punto x al punto y, con las vacas, puedes llevar 2 maximo y minimo 1 en el menor tiempo posible");
            Console.WriteLine("Presione enter para avanzar");
            Console.ReadLine();
            Console.Clear();
            Vacas vaca = new Vacas();
            vaca.Nombrar();
            vaca.Desplegar();
            vaca.Mover();
            vaca.Desplegar();
            Console.Clear();
            vaca.Mover();
            vaca.Desplegar();
            Console.Clear();
            vaca.Mover();
            vaca.Desplegar();
            Console.Clear();
            vaca.Mover();
            vaca.Desplegar();
            Console.Clear();
            vaca.Mover();
            vaca.Desplegar();
            Console.Clear();
            Console.ReadKey();

        }

    }
}
