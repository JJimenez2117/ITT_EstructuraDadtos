using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesoShell shellSorts = new ProcesoShell();
            shellSorts.Valores();
            shellSorts.Shell();
            shellSorts.Imprimir();
        }
    }
}
