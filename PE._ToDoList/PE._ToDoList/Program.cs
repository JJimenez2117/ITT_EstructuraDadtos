using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarea tareas = new Tarea();
            int menu = 0, opc = 0;
            string regresar = "";
            
            do {
            
               
                Console.WriteLine("Escriba:\n1 Para ver tareas \n2 Para agregar tareas ");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)//Ver tareas
                {
                    Console.WriteLine("Escriba: \n1 Para ver tareas pendientes \n2 Para ver tareas en proceso \n3 Para ver tareas finalizadas");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1://Tareas pendientes
                            
                                tareas.VerPendientes();
                                break;
                            
                        case 2://Tareas en proceso
                            { 
                                tareas.Terminar();
                                break;
                            }
                        case 3://Tareas finalizadas
                            {
                                tareas.YaTerminada();
                                break;
                            }
                        default://Salida
                            {
                                break;
                            }
                    }
                }
                else
                {
                   
                    tareas.Agregar();

                }
                Console.ReadKey();
                Console.Clear();
                Console.Write("Desea regresar al menu? SI/NO");
                regresar = Console.ReadLine().ToUpper();

            }
            while (regresar=="SI");
            

                
        }
    }
}
