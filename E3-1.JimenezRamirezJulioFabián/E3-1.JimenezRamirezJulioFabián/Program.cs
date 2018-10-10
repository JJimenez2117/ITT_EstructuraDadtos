using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.JimenezRamirezJulioFabián
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string opc;
            do
            {
                Console.Write("Escriba la cantidad de materias");//ingresar la cantidad de materias
                cantidad = Convert.ToInt32(Console.ReadLine());
                Proceso proceso = new Proceso();
                proceso.Calificacion(cantidad);//Llamar al metodo
                Console.WriteLine("Desea repetir el proceso?si/no");
                opc = Console.ReadLine().ToUpper();
                Console.ReadKey();
            }
            while (opc == "SI");
        }
    }
}
