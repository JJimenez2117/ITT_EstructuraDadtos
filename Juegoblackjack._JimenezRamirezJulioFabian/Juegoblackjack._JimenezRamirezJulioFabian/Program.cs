using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juegoblackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            string oc;
            do
            {

                try
                {
                    Process blackJack = new Process();
                    blackJack.Jugar();
                    blackJack.Jalar();
                    blackJack.Jalar();
                    blackJack.Ganar();
                    Console.ReadKey();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.Write("desea intentarlo otra vez?S/N");
                oc = Console.ReadLine();
            }

            while (oc.ToLower() == "s");
        }
    }
}
