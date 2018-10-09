using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU2._JimenezRamirezJulioFabian
{
    class Recursividad
    {
        public int Sumar(string cadena, int veces, int suma)
        {
            char[] valores;
            valores = cadena.ToCharArray();
            if (veces > 0)
                suma = Convert.ToInt32(Convert.ToString(valores[veces - 1])) + Sumar(cadena, veces - 1, suma);
            return suma;
        }
    }

}
