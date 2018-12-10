using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHash
{
    public class Proceso
    {
      
        public void Agregar()
        {
            
            Hashtable owo = new Hashtable();
            int cantidad = 0;
            string nombre = "";
            int num = 0;
            string boi;
            do
            {
                Console.Clear();
                Console.Write("Escriba el numero de alumnos ");//ingresa la cantidad de alumnos
                cantidad = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Escriba el numero de control ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Escriba el nombre del alumno ");
                    nombre = Console.ReadLine();
                    owo.Add(num, nombre);//Primero se pone la llave y luego el valor
                }
                Console.Clear();
                foreach (DictionaryEntry item in owo)
                {
                    Console.WriteLine("El numero de control es:{0} ", item.Key);
                }
                int control = 0;

                Console.WriteLine("Escriba el numero de control que desee para desplegar su nombre");

                control = Convert.ToInt32(Console.ReadLine());
                if (owo.Contains(control))//si esta lo despliega 
                {
                    Console.WriteLine(" el nombre del alumno es {0} ", owo[control]);//Colocando el puro numero despliega el nombre
                }
                else//si no pues despliega que no existe
                {
                    Console.WriteLine("No existe la palabra");
                }
                Console.Write("Quiere volver a intentarlo?S/N");
                boi = Console.ReadLine().ToUpper();
            } while (boi=="S");

        }

      
    }
}
