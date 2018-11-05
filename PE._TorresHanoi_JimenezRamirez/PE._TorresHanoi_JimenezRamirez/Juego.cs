using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._TorresHanoi_JimenezRamirez
{
    public class Juego
    {//Se crean las listas que se van a utilizar de cada torre
        Stack<int> Torre1 = new Stack<int>();
        Stack<int> Torre2 = new Stack<int>();
        Stack<int> Torre3 = new Stack<int>();
        int num;//numero de discos btw
        public void Empezar()
        {           
            Console.Write("Escriba la cantidad de discos");
            num = Convert.ToInt32(Console.ReadLine());
            for (int contador=num;contador> 0;contador--)//Se agregan los valores a la torre
            {
                Torre1.Push(contador);
            }
            
            Console.ReadLine();
            
        }

        public void Jugar()
        {
            Empezar();
            Desplegar();
            Proceso(num,ref Torre1, ref Torre2, ref Torre3,"1","2","3");//Se mandan los parametros segun su tipo
            Console.Clear();
            Desplegar();
            Console.ReadKey();
        }
        public void Desplegar()//Al final se despliega una torre
        {
            Console.WriteLine("Torre 1");
            foreach (int item in Torre1)
            {

                Console.WriteLine("\t-{0}", item);
            }
            Console.WriteLine("Torre 2");
            foreach (var item in Torre2)
            {

                Console.WriteLine("\t-{0}", item);
            }
            Console.WriteLine("Torre 3");
            foreach (var item in Torre3)
            {
                Console.WriteLine("\t-{0}", item);
            }
        }

        public void Proceso(int discos, ref Stack<int> Torre1,ref Stack<int>Torre2, ref Stack<int>Torre3,string torre1, string torre2, string torre3)//El metodo con parametros que es el proceso de mover
        {
            Console.WriteLine(discos);
            if (discos==1)//si es un disco pues se manda al 3
            {
                Console.WriteLine("El disco se smueve de le la torre{0} se hacia la torre{1}", torre1, torre2);;
                Torre3.Push(1);
                Torre1.Pop();
            }
            else 
            {
                Proceso(discos - 1, ref Torre1, ref Torre3, ref Torre2, torre1, torre3, torre2);//Se llama al mismo metodo para hacer recursividad pero el orden de los parametros cambia 
                Console.WriteLine("El disco se mueve de la torre {0} hacia la torre {1}", torre1, torre2);
                Torre2.Push(Torre1.Pop());
                Console.WriteLine("wea {0}", discos);
                Proceso(discos - 1, ref Torre3, ref Torre2, ref Torre1, torre3, torre2, torre1);//Se llama al mismo metodo para hacer recursividad pero el orden de los parametros cambia
            }
            Console.ReadLine();
            
        }
    }
}
