using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Cartas
    {
        int contador = 0;
        double cartas = 0;
        double primeras = 0;
        Tree arbol = new Tree();//de donde vienen los valores ;)
        public void Ingresar(int num)
        {
            if (contador < 7)
            {
                contador++;
                arbol.Insertar(num); //se agregan los valores al arbolito
                Ingresar(num);
            }
        }

        public void CartasCalcular(int num)
        {
            //cartas enviadas
            for (int contador2 = 0; contador2 < Math.Pow(5, 6); contador2++) 
            {
                cartas = cartas + num;
            }
            //suma las primeras semanas
            for (int contador2 = 0; contador2 < Math.Pow(5, 3); contador2++) 
            {
                primeras = primeras + num;
            }
        }

        public void CartasPrintStation()
        {//EL proceso se multiplica por 2, porque empezamos con dos personas
            Console.WriteLine("Número de cartas enviadas: " + cartas * 2); 
        }

        public void CartasDom()
        {
            Console.WriteLine("Número de cartas enviadas los últimos 3 domingos: " + (cartas - primeras) * 2); //Se restan las primeras semanas sumadas
        }


    }
}
