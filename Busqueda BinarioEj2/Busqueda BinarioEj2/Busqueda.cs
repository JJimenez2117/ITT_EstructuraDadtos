using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_BinarioEj2
{
    public class Busqueda
    {
        public void Arreglo()
        {
            int cantidad;
            Console.WriteLine("Escriba la cantidad de elementos que quiere en el arreglo");//se agrega la cantidad de elementos
            cantidad = Convert.ToInt32(Console.ReadLine());
            string[] owo = new string[cantidad];//se crea el arreglo
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Escriba la frase o letra {0}", i + 1);//se agregan los valores al arreglo
                owo[i] =Console.ReadLine();
            }

            string tem;//Variable temporal

            for (int contador = 0; contador < owo.Length; contador++)//Tssssss metodo de la burbuja para acomodarlos por temaño del elemento
            {
                for (int i = 1; i < owo.Length; i++)
                {
                    if (owo[i - 1].Length > owo[i].Length )//El if es por si el anterior es mayor que el siguiente numero
                    {//si sí se cambia de posicion
                        tem = owo[i];//Se guarda como valor actual
                        owo[i] = owo[i - 1];//Se cambia el valor de posicion
                        owo[i - 1] = tem;//Ahora se cambia el otro valor
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < owo.Length; i++)//Se despliega el arreglo
            {
                Console.WriteLine(owo[i]);
            }       

            int mitad;
            mitad = (cantidad) / 2;//se obtiene el valor de en medio
            Console.Write("Escriba la palabra que desea buscar ");
            string valor = Console.ReadLine();//Se ingresa el valor a buscar

            if (owo[mitad] == valor)//si el valor de la mitad es el valor buscado
            {
                Console.WriteLine("El valor esta en la posicion {0}", mitad + 1);//se despliega el valor de en medio +1 porque se redondea hacia abajo
            }
            else if (owo[mitad].Length < valor.Length)//si el valor buscado es mayor que la mitad
            {

                string[] temp = new string[cantidad - mitad];//es el resto de la mitad, ya que si es impar se perderian valores
                for (int contador = mitad; contador < cantidad; contador++)
                {
                    temp[contador - mitad] = owo[contador];//Se ponen en un arreglo temporal que va a ser la mitad del arreglo menor
                }
                for (int i = 0; i < (cantidad - mitad); i++)//Este va a servir para el if, si no se encuentra el valor pues no pasa nada
                {
                    if (temp[i] == valor)//si el valor del arreglo en la posicion del contador
                    {
                        Console.WriteLine("El valor está en la posicion {0}", i + mitad + 1);//se despliega la posicion
                    }
                    else { }//si ponia algo dentro del else iba a aparecer todas las veces que no fuera el valor asi que mejor no puse nada
                }

            }
            else if (owo[mitad].Length > valor.Length)//Es lo mismo pero cuando el valor buscado es menor a la mitad
            {
                string[] temp = new string[mitad];
                for (int contador = 0; contador < mitad; contador++)
                {
                    temp[contador] = owo[contador];
                }
                for (int i = 0; i < mitad; i++)
                {
                    if (temp[i] == valor)
                    {
                        Console.WriteLine("El valor está en la posicion {0}", i + 1);
                    }
                    else { }
                }

            }

        }
    }
}
