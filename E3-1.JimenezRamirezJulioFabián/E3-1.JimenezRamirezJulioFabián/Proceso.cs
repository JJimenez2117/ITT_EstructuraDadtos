using System;
using System.Collections;//se agrega el system collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1.JimenezRamirezJulioFabián
{
    class Proceso
    {
        //se crean los array list
        ArrayList materias = new ArrayList();
        ArrayList alumnos = new ArrayList();
        ArrayList calificaciones = new ArrayList();

        public void Calificacion(int cantidad)//el metodo que se usará
        {
            for (int i = 0; i <cantidad ; i++)//capturar o agregar la cantidad de materias
            {
                Console.Write("Escriba el nombre de la materia {0} ",i+1);
                materias.Add(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Escriba la cantidad de alumnos en {0} ", materias.ToArray().ElementAt(i)); //capturar o agregar la cantidad de alumnos 
                alumnos.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Clear();

            for (int i = 0; i < cantidad; i++)//capturar la calificacion de los alumnos con su respectiva materia
            {
                for (int j = 0; j < Convert.ToInt32(alumnos.ToArray().ElementAt(i)); j++)
                {
                    Console.Write("Escriba la calificacion del alumno {0} de la materia {1}",j+1,materias.ToArray().ElementAt(i));
                    calificaciones.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Console.Clear();
            foreach (var item in materias)//desplegar nombre de la materia
            {
                Console.WriteLine(item);
                for (int i = 0; i < Convert.ToInt32(alumnos.ToArray().ElementAt(materias.IndexOf(item))); i++)//Desplegar la calificacion de cada alumno
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", i + 1, calificaciones.ToArray().ElementAt(i));
                    
                }
            }
        }
    }
}
