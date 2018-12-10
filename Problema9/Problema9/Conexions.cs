using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    public class Conexions
    {
        Grafo Grafo1 = new Grafo(5);
        Grafo Grafo2 = new Grafo(6);
        Grafo Grafo3 = new Grafo(9);

        public Conexions()
        {
            LlenarGrafos();
        }

         public void LlenarGrafos()
        {
            //Grafo1
            Grafo1.AgregarC(0, 4);
            Grafo1.AgregarC(4, 1);
            Grafo1.AgregarC(1, 0);
            Grafo1.AgregarC(1, 2);
            Grafo1.AgregarC(3, 4);
            Grafo1.AgregarC(3, 1);
            Grafo1.AgregarC(3, 2);

            //Grafo2
            Grafo2.AgregarC(0, 5);
            Grafo2.AgregarC(1, 0);
            Grafo2.AgregarC(2, 1);
            Grafo2.AgregarC(2, 3);
            Grafo2.AgregarC(3, 4);
            Grafo2.AgregarC(4, 2);
            Grafo2.AgregarC(4, 5);

            //Grafo3
            Grafo3.AgregarC(0, 8);
            Grafo3.AgregarC(0, 2);
            Grafo3.AgregarC(1, 0);
            Grafo3.AgregarC(1, 7);
            Grafo3.AgregarC(1, 2);
            Grafo3.AgregarC(3, 2);
            Grafo3.AgregarC(3, 4);
            Grafo3.AgregarC(3, 1);
            Grafo3.AgregarC(4, 3);
            Grafo3.AgregarC(5, 3);
            Grafo3.AgregarC(5, 6);
            Grafo3.AgregarC(5, 4);
            Grafo3.AgregarC(6, 2);
            Grafo3.AgregarC(6, 3);
            Grafo3.AgregarC(7, 5);
            Grafo3.AgregarC(7, 6);
            Grafo3.AgregarC(7, 8);
            Grafo3.AgregarC(8, 0);
            Grafo3.AgregarC(8, 6);
        }

        public void Iniciar()
        {
            Console.Write("Elementos fuertemente conexos del grafo 1: \n");
            Grafo1.ImprimirConexions();
            Console.ReadLine();
            Console.Write("Elementos fuertemente conexos del grafo 2: \n");
            Grafo2.ImprimirConexions();
            Console.ReadLine();
            Console.Write("Elementos fuertemente conexos del grafo 3: \n");
            Grafo3.ImprimirConexions();
            Console.ReadLine();
        }
    }
}
