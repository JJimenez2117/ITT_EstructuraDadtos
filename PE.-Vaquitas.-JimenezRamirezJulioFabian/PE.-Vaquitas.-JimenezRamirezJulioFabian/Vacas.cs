using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._Vaquitas._JimenezRamirezJulioFabian
{
    public class Vacas
    {//Se crean las listas
        List<string> x = new List<string>();
        List<string> y = new List<string>();
        int[] tiempo = new int[4]{ 2, 4, 10, 20 };//un arreglo para el tiempo
        int owo;//variable para desplegar el tiempo

        public void Nombrar()
        {//se agregan las vacas antes del puente
            x.Add("Mazie la de 2");
            x.Add("Daisy la de 4");
            x.Add("Crazy la de 10");
            x.Add("Lazy la de 20");
        }
        public void Mover()
        {
            int contadorx = x.Count;
            int contadory = y.Count;
            switch(contadorx)
            {
                case 4:
                    {//Cuando estan todas las vacas se van la de 2 y4
                        x.Remove("Mazie la de 2");
                        y.Add("Mazie la de 2");
                        x.Remove("Daisy la de 4");
                        y.Add("Daisy la de 4");
                        owo = tiempo.ElementAt(1);
                        Console.WriteLine("El tiempo que duro es {0}", owo);
                        break;
                    }
                case 2:
                    {//Hay dos veces que hay dos vacas antes del puente
                        if (Convert.ToBoolean(y.Contains("Crazy la de 10")))//Esta es el ultimo paso, regresa la vaca 2 y 4
                        {
                            x.Remove("Mazie la de 2");
                            x.Remove("Daisy la de 4");
                            y.Add("Mazie la de 2");
                            y.Add("Daisy la de 4");
                            owo =owo+ tiempo.ElementAt(1);
                            Console.WriteLine("El tiempo que duró es {0}", owo);
                        }
                        else 
                        {//este sucede cuando se regresa sola la de 2
                            y.Remove("Mazie la de 2");
                            x.Add("Mazie la de 2");
                            owo = tiempo.ElementAt(0)+owo;
                            Console.WriteLine("El tiempo que duró es {0}", owo);
                        }
                        break;
                    }
                case 3:
                    {//Este regresa la de 10 y 20
                        x.Remove("Crazy la de 10");
                        x.Remove("Lazy la de 20");
                        y.Add("Crazy la de 10");
                        y.Add("Lazy la de20");
                        owo = owo+ tiempo.ElementAt(3);
                        Console.WriteLine("El tiempo que duró es {0}", owo);
                        break;
                    }
                case 1://Regresa sola la vaca de 4
                    {
                        y.Remove("Daisy la de 4");
                        x.Add("Daisy la de 4");
                        owo = owo+tiempo.ElementAt(1);
                        Console.WriteLine("El tiempo que duró es {0}", owo);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            

            

        }
        public void Desplegar()
        {//Se despliega
            Console.WriteLine("Vacas antes del puente");
            foreach (string item in x)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("Vacas despues del puente");
            foreach (string item in y)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
        }
        
    
    }
}
