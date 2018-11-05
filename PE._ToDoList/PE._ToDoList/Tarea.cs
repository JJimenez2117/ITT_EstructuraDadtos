using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._ToDoList
{
    public class Tarea
    {//Listas que se van a ocupar
        List<Datos> Listaglobal = new List<Datos>();
        List<Datos> Pendiente = new List<Datos>();
        List<Datos> Proceso = new List<Datos>();
        List<Datos> Terminada = new List<Datos>();

        public void Agregar()//Se agregan los datos 
        {
            Datos tarea = new Datos();
            Console.WriteLine("Escriba el Id: ");
            tarea.Id = Console.ReadLine();
            Console.WriteLine("Escriba el nombre de la tarea");
            tarea.NombreTarea = Console.ReadLine();
            Console.WriteLine("Escriba la descripción");
            tarea.Descripcion = Console.ReadLine();
            Console.WriteLine("Escriba la fecha de inicio");
            tarea.FechaI = Console.ReadLine();
            Console.WriteLine("Escriba la fecha de finalización");
            tarea.FechaF = Console.ReadLine();
            Console.WriteLine("Escriba el status de la tarea:PE/PR, Pendiente o proceso respectivamente");
            tarea.Status = Console.ReadLine().ToUpper();
            if (tarea.Status == "PE")
            {
                Pendiente.Add(tarea);
                Listaglobal.Add(tarea);
            }
            else
            {
                Proceso.Add(tarea);
                Listaglobal.Add(tarea);
            }

        }
        public void VerPendientes()//Metodo para ver las tareas pendientes
        {

            Console.WriteLine("Elija una de las tareas pendientes, escriba el id de la tarea");

            foreach (var item in Pendiente)//Despliega las tareas pendientes
            {
                Console.WriteLine(item.Id + " " + item.NombreTarea);
            }
            string opc = Console.ReadLine();
            var seleccion = (from elegir in Listaglobal where opc == elegir.Id select elegir).ToList();//Este es el paso importante para elegir el atributo
                                                                                                       //Dentro del objeto de la lista
            foreach (var item in seleccion)//Se despliega la lista elegida
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nombre de la tarea: " + item.NombreTarea);
                Console.WriteLine("Descripción: " + item.Descripcion);
                Console.WriteLine("Fecha inicial: " + item.FechaI);
                Console.WriteLine("Fecha final: " + item.FechaF);
                Console.WriteLine("Fecha de status: " + item.Status);

            }

            foreach (var item1 in seleccion)//Este foreach es para el proceso de cambiar el status 
            {
                Listaglobal.Remove(item1);
                item1.Status = "Proceso";
                Proceso.Add(item1);
                Pendiente.Remove(item1);
                Listaglobal.Add(item1);
            }
            seleccion.Clear();
        }
        public void Terminar()//Metodo para ver las tareas en proceso
        {
            Datos tarea = new Datos();
            Console.WriteLine("Eliga una de las tareas en proceso, escriba el id de la tarea");
            string opc = Console.ReadLine();
            foreach (var item in Proceso)//Despliega las tareas en proceso
            {
                Console.WriteLine(item.Id+" "+ item.NombreTarea);
            }
            var seleccion = (from elegir in Listaglobal where opc == elegir.Id select elegir).ToList();//Este es el paso importante para elegir el atributo
                                                                                                       //Dentro del objeto de la lista
            foreach (var item in seleccion)//Se despliega la lista elegida
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nombre de la tarea: " + item.NombreTarea);
                Console.WriteLine("Descripción: " + item.Descripcion);
                Console.WriteLine("Fecha inicial: " + item.FechaI);
                Console.WriteLine("Fecha final: " + item.FechaF);
                Console.WriteLine("Fecha de status: " + item.Status);
            }


            foreach (var item1 in seleccion)//Este foreach es para el proceso de cambiar el status 
            {
                Listaglobal.Remove(item1);
                item1.Status = "terminada";
                Terminada.Add(item1);
                Proceso.Remove(item1);
                Listaglobal.Add(item1);
            }
            seleccion.Clear();
        }
        public void YaTerminada()//Metodo para ver las tareas terminadas
        {
            Datos tarea = new Datos();
            Console.WriteLine("Eliga una de las tareas terminadas, escriba el id de la tarea");
            string opc = Console.ReadLine();
            foreach (var item in Terminada)//Despliega el id y nombre de las tareas terminadas
            {
                Console.WriteLine(item.Id+" "+ item.NombreTarea);

            }
            var seleccion = (from elegir in Listaglobal where opc == elegir.Id select elegir).ToList();//Este es el paso importante para elegir el atributo
                                                                                                       //Se utiliza la global para poder hacer copy-paste a gusto                                //Dentro del objeto de la lista
            foreach (var item in seleccion)//Se despliega la lista elegida
            {
                Console.WriteLine("ID: "+item.Id);
                Console.WriteLine("Nombre de la tarea: "+item.NombreTarea);
                Console.WriteLine("Descripción: "+item.Descripcion);
                Console.WriteLine("Fecha inicial: "+item.FechaI);
                Console.WriteLine("Fecha final: "+item.FechaF);
                Console.WriteLine("Fecha de status: "+item.Status);
                

            }


            foreach (var item1 in seleccion)//Este foreach es para el proceso de cambiar el status ]
            {
                Listaglobal.Remove(item1);
                item1.Status = "Proceso";
                Proceso.Add(item1);
                Terminada.Remove(item1);
                Listaglobal.Add(item1);
            }
            seleccion.Clear();
        }
        public void TodasTareas()//Metodo para ver las tareas pendientes
        {
            Datos tarea = new Datos();
            Console.WriteLine("Eliga una de las tareas");
            string opc = Console.ReadLine();
            foreach (var item in Pendiente)//Despliega todas la tareas pero nomas su nombre y id porque es más comoda
            {
                Console.WriteLine(item.Id, item.NombreTarea);
            }
            var seleccion = (from elegir in Listaglobal where opc == elegir.Id select elegir).ToList();//Este es el paso importante para elegir el atributo
                                                                                                       //Dentro del objeto de la lista
            foreach (var item in seleccion)//Se despliega la lista elegida
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Escriba un segundo comentario");

            foreach (var item1 in seleccion)//Este foreach es para el proceso de cambiar el status 
            {
                Listaglobal.Remove(item1);
                item1.Status = "Proceso";
                Proceso.Add(item1);
                Pendiente.Remove(item1);
                Listaglobal.Add(item1);
            }
            seleccion.Clear();// Este es para que la lista no se repita
        }
    }
}
