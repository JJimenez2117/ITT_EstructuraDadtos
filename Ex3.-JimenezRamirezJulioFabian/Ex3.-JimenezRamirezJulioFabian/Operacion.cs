using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ex3._JimenezRamirezJulioFabian
{
    public class Operacion
    {

            Stack Lista = new Stack();
            Queue Cola = new Queue();
        LinkedList<Object> Ligada = new LinkedList<Object>();
        List<Object> Listona = new List<Object>();
        List<Clase> Salon = new List<Clase>();        

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Lista.Clear();
            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();

            Console.WriteLine("El ejercicio 1: ");

            foreach (int item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Programa 1 ejecutado");
            Console.ReadLine();
            Lista.Clear();

        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            int cantidad = 0;
            Console.Write("Cuantas palabras ingresará: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            List<string> valoresPalabra = new List<string>();
            LinkedList<string> reservadas = new LinkedList<string>();
            LinkedList<string> Identificadores_Literales = new LinkedList<string>();

            for (int contador = 0; contador < cantidad; contador++)
            {
                Console.WriteLine("Ingrese la palabra: ");
                valoresPalabra.Add(Console.ReadLine());
            }

            string[] valoresKeyWord = new string[107] {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked","class", "const",
                                               "continue",  "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit",
                                               "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
                                                "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
                                                "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref",
                                                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                                                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                                                "using", "using", "static", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "async",
                                                "await", "by", "descending", "dynamic", "equals", "from", "get", "global", "groupo", "into", "join", "let",
                                                "nameof", "on", "orderby", "partial", "remove", "select", "set", "value", "var", "when", "where", "yield"};
            List<string> palabras = new List<string>();
            foreach (var item in valoresKeyWord)
            {
                palabras.Add(item);
            }

            Console.WriteLine("\nEstas palabras son clave: ");
            foreach (var item in valoresPalabra)
            {
                Identificadores_Literales.AddLast(item);
                foreach (var item2 in valoresKeyWord)
                {
                    if (item == item2)
                    {
                        Console.WriteLine(item2);
                        Identificadores_Literales.Remove(item);
                        reservadas.AddLast(item2);
                    }
                }
            }

            Console.WriteLine("\nIdentificadores y literales: ");
            foreach (var item in Identificadores_Literales)
            {
                Console.WriteLine(item);
            }


        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Console.WriteLine("Empieza el programa 3");
            var tiempo = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {

                Listona.Add("hola");
                
            }
            tiempo.Stop();
            var tiempoL = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {


                Ligada.AddLast("hola");
            }
           
            tiempoL.Stop();
            Console.WriteLine("El tiempo de la lista es {0}", tiempo.Elapsed.TotalMilliseconds);
            Console.WriteLine("El timepo de la lista ligada es {0}", tiempoL.Elapsed.TotalMilliseconds);
            Console.WriteLine("Aqui acaba el ejercicio 3");
            Console.ReadKey();

        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            try
            {
                string maestro = "";
                string materia = "";
                Console.Write("Ingrese nombre del maestro: ");
                maestro = Console.ReadLine();
                Console.Write("Ingrese materia del curso: ");
                materia = Console.ReadLine();
                Console.Write("Cuantos alumnos va a ingresar (minimo deben de ser 30):");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad >= 30)
                {
                    for (int contador = 0; contador < cantidad; contador++)
                    {
                        Clase objClase = new Clase();
                        Console.Write("Ingrese nombre del alumno {0}: ", contador + 1);
                        objClase.Alumno = Console.ReadLine();
                        Console.Write("Ingrese califacion del alumno {0}: ", contador + 1);
                        objClase.Calificacion = Convert.ToInt32(Console.ReadLine());
                        objClase.Maestro = maestro;
                        objClase.NombreClase = materia;
                        Salon.Add(objClase);
                    }

                    Console.Clear();
                    Console.Write("Mayores\n");
                    Mayor();
                    Console.Write("Menores\n");
                    Menor();
                    Console.Write("Promedio\n");
                    Promedio();
                    Salon.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Ingrese al menos 30 alumnos");
                    Console.ReadLine();
                    Ejercicio4();
                }
            }
            catch (Exception e)
            {
                Console.Write("Error encontrado: {0}", e.Message);
            }

        }

        private void Mayor()
        {
            Salon = (from alumnos in Salon orderby alumnos.Calificacion descending select alumnos).ToList();
            foreach (Clase objeto in Salon)
            {
                if (objeto.Calificacion == Salon[0].Calificacion)
                {
                    Console.Write("El nombre del alumno  con calificacion mayor es: {0}\n", objeto.Alumno);
                    Console.Write("La calificacion mayor es: {0}\n", objeto.Calificacion);
                }
            }
        }

        private void Menor()
        {
            Salon = (from alumno in Salon orderby alumno.Calificacion ascending select alumno).ToList();
            foreach (Clase objeto in Salon)
            {
                if (objeto.Calificacion == Salon[0].Calificacion)
                {
                    Console.Write("El nombre del alumno con la califición menor es: {0}\n", objeto.Alumno);
                    Console.Write("La calificacion menor es: {0}\n", objeto.Calificacion);
                }
            }
        }

        private void Promedio()
        {
            double acumulador = 0;
            foreach (Clase Objeto in Salon)
            {
                acumulador = acumulador + Objeto.Calificacion;
            }
            Console.Write("El promedio fue de: {0}", acumulador / Salon.Capacity);
        }
    
    }
}
