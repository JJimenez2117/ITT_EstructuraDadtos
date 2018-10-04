using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2._U2._JimenezRamirezJulioFabian
{
    class Invierte
    {
        public void Invertir(int veces, params int[] valores)
        {
            double actual = 0;
            if (veces > 0)
            {
                actual = valores[veces - 1];
                Console.Write(actual + " ");
                Invertir(veces - 1, valores);
            }
        }
    }
    class ValorMinimo
    {
        public int VMinimo(int contador, int minimo, int[] valores)
        {

            if (contador != valores.Length)
            {
                if (valores[contador] < minimo)
                {
                    minimo = VMinimo(contador + 1, valores[contador], valores);
                }
                else
                {
                    minimo = VMinimo(contador + 1, minimo, valores);
                }
            }
            return minimo;
        }
    }
    public class ValorMayor
    {
        public int VMayor(int contador, int mayor, int[] valores)
        {

            if (contador != valores.Length)
            {
                if (valores[contador] > mayor)
                {
                    mayor = VMayor(contador + 1, valores[contador], valores);
                }
                else
                {
                    mayor = VMayor(contador + 1, mayor, valores);
                }
            }
            return mayor;
        }
    }
    public class Datos
    {
        public int[] pedirNumeros(int largo)
        {
            int[] valores = new int[largo];
            for (int contador = 0; contador < largo; contador++)
            {
                Console.Write("\nIngresa un valor {0}: ", contador + 1);
                valores[contador] = Convert.ToInt32(Console.ReadLine());
            }
            return valores;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            while (opc != 4)
            {
                try
                {
                    Console.Write("Eliga una opción: \n1.- Valor mínimo \n2.- Valor máximo \n3.- Invertir los valores \n4.- Salir \nTeclee el número de la opción: ");
                    opc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEscriba la cantidad de numeros: ");
                    int largo = Convert.ToInt32(Console.ReadLine());
                    Datos datos = new Datos();
                    int[] valores = new int[largo];
                    valores = datos.pedirNumeros(largo);
                    

                    switch (opc)
                    {
                        case 1:
                            ValorMinimo minimo = new ValorMinimo();
                            Console.Write("El minimo es: " + minimo.VMinimo(0, valores[0], valores));
                            Console.ReadKey();
                            break;
                        case 2:
                            ValorMayor mayor = new ValorMayor();
                            Console.Write("El mayor es: " + mayor.VMayor(0, valores[0], valores));
                            Console.ReadKey();
                            break;
                        case 3:
                            Invierte inv = new Invierte();
                            Console.Write("Los números invertidos son: ");
                            inv.Invertir(largo, valores);
                            Console.ReadKey();
                            break;
                        case 4:
                            opc = 4;
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }

}