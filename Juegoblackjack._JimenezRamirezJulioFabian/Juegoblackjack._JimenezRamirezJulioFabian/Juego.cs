using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegoblackjack
{
  
    public class Process
    {
        //arreglo para la baraja
        string[] baraja;
        string simbolo = "";
        Stack<Carta> cartas;//Pila para luego usar la baraja
        public int[] mano = new int[5];//Numero de cartas que se pueden tener en la mano
        int numeromano = 0, As = 0, opc = 0;

        //Este metodo genera revolver la baraja asÃ­ como crearla
        public void Jugar()
        {
            //Se crea el obejot aleatorio
            Random random = new Random();
            int contador = 0;
            baraja = new string[52];
            //Este for es para los simbolos que hay que son 4
            for (int i = 1; i < 5; i++)
            {
                //Se crea el switch para darle el simbolo 
                switch (i)
                {
                    case 1: simbolo = "C"; break;
                    case 2: simbolo = "D"; break;
                    case 3: simbolo = "T"; break;
                    case 4: simbolo = "P"; break;
                    default: break;
                }//Cada numero de carta puede tener 4 simbolos, entonces 13x4 52
                for (int j = 1; j < 14; j++)
                {
                    if (j != 1)//Si el valor es 1 la carta es A
                    {
                        if (j >= 11)//Se crea el switch para darle el j,q,k al que corresponde, ya que el numero de carta 11,12,13 pertecen a cada una respectivamente
                        {
                            switch (j)
                            {
                                case 11: baraja[contador] = string.Format("{0} J", simbolo); break;
                                case 12: baraja[contador] = string.Format("{0} Q", simbolo); break;
                                case 13: baraja[contador] = string.Format("{0} K", simbolo); break;
                                default: break;
                            }
                        }
                        else//de la carta 2 a 10 son sencillos
                        {
                            baraja[contador] = string.Format("{0} {1}", simbolo, j);
                        }
                    }
                    else { baraja[contador] = string.Format("{0} A", simbolo); }//1=A
                    contador++;
                }

            }
            cartas = new Stack<Carta>();//se barajea la carta con el objeto creado
            baraja = baraja.OrderBy(barajeoaleatorio => random.Next()).ToArray();
            foreach (string item in baraja)
            {
                Carta tcarta = new Carta();
                tcarta.valor = item;
                cartas.Push(tcarta);
            }

        }
        public void Jalar()//Es para jalar una carta ya sean las dos primeras o extra
        {
            Console.WriteLine("Carta No.{0}\t{1}\t", (numeromano + 1), (cartas.Peek()).valor);
            char[] sim = { ' ', 'D', 'C', 'T', 'P' };

            string temp = string.Format("{0}", ((cartas.Peek()).valor.ToString()).Trim(sim));

            if (temp != "A")
            {//Convierte a valores enteros
                switch (temp)
                {
                    case "J": mano[numeromano] = 10; break;
                    case "Q": mano[numeromano] = 10; break;
                    case "K": mano[numeromano] = 10; break;
                    default: mano[numeromano] = int.Parse(temp); break;
                }
            }
            else
            {
                As++;

            }

            cartas.Pop();
            numeromano++;
        }
        public int ValorA()//cuenta cartas al igual que elige el valor de A
        {
            int temporal = 0;
            foreach (var item in mano)
            {
                temporal = temporal + item;
            }
            switch (As)
            {//Aqui se le da el valor de A comparando, ya puede ser que te salga una o mÃ¡s A
                case 1:
                    if (temporal <= 10)
                    {
                        temporal = temporal + 11;
                    }
                    else
                    {
                        temporal = temporal + 1;
                    }
                    break;
                case 2:
                    if (temporal <= 9)
                    {
                        temporal = temporal + 12;
                    }
                    else
                    {
                        temporal = temporal + 2;
                    }
                    break;
                case 3:
                    if (temporal <= 8)
                    {
                        temporal = temporal + 13;
                    }
                    else
                    {
                        temporal = temporal + 3;
                    }
                    break;
                case 4:
                    if (temporal <= 7)
                    {
                        temporal = temporal + 14;
                    }
                    else
                    {
                        temporal = temporal + 4;
                    }
                    break;
                default: break;

            }

            return temporal;
        }

        public void Ganar()//Se decide si jalas otra carta para ganar
        {




            int ganar = ValorA();
            if (ganar < 21 && opc < 3)
            {
                Console.WriteLine("Â¿Quieres otra carta? S/N");
                string lec = Console.ReadLine().ToUpper();
                switch (lec)
                {
                    case "S":
                        opc++;
                        Jalar();
                        break;
                    case "N":
                        opc = 6;
                        break;
                    default:
                        Console.WriteLine("Perderas");
                        break;
                }
                Ganar();
            }
            if (opc > 2 || ganar == 21)
            {
                if (opc == 6)
                {
                    Console.WriteLine("Terminaste el juego con {0} puntos", ganar);

                }
                if (ganar == 21)
                    Console.WriteLine("Ganaste e ignore si le sale otro mensaje xD");

            }
            else
            {
                Console.WriteLine("Perdiste");

            }





        }



    }
}
